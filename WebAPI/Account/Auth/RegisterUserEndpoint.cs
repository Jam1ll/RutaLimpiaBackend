using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RutaLimpiaBackend.Core.Application.DTOs.Account.Register;
using RutaLimpiaBackend.Core.Domain.Entities.Enums;
using RutaLimpiaBackend.Infrastructure.Identity.Entities;

namespace WebAPI.Account.Auth
{
    public class RegisterUserEndpoint : EndpointBaseAsync
        .WithRequest<RegisterUserRequest>
        .WithActionResult<RegisterUserResponse>
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RegisterUserEndpoint(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpPost("api/v1/auth/register")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(RegisterUserRequest), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public override async Task<ActionResult<RegisterUserResponse>> HandleAsync([FromBody] RegisterUserRequest request, CancellationToken cancellationToken = default)
        {
            var response = new RegisterUserResponse();

            var userExists = await _userManager.FindByEmailAsync(request.Email);

            if (userExists != null)
            {
                response.Errors.Add("El correo electrónico ya se encuentra registrado");
                return Conflict(response);
            }

            var user = new User
            {
                UserName = request.Email,
                Email = request.Email,
                Name = request.Name,
                SectorId = request.SectorId,
                PhoneNumber = request.PhoneNumber ?? "0000000000",
                PhotoUrl = request.PhotoUrl ?? "no_photo_found",
                CreatedAt = DateTime.UtcNow,
                IsActive = request.IsActive,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(user, request.Password);

            if (!result.Succeeded)
            {
                response.Errors.AddRange(result.Errors.Select(e => e.Description));
                return BadRequest(response);
            }

            if (!string.IsNullOrEmpty(request.Role))
            {
                if (await _roleManager.RoleExistsAsync(request.Role))
                {
                    await _userManager.AddToRoleAsync(user, request.Role);
                }
                else
                {
                    response.Errors.Add($"El rol '{request.Role}' no existe en el sistema.");
                    return BadRequest(response);
                }
            }

            response.UserId = user.Id;
            response.Message = "Usuario creado exitosamente.";
            response.Success = true;

            return Ok(response);
        }
    }
}