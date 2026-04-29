using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RutaLimpiaBackend.Core.Application.DTOs.Account.Update;
using RutaLimpiaBackend.Infrastructure.Identity.Entities;

namespace WebAPI.Account
{
    public class UpdateUserEndpoint : EndpointBaseAsync
        .WithRequest<UpdateUserRequest>
        .WithActionResult
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UpdateUserEndpoint(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpPut("api/v1/User/Update")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public override async Task<ActionResult> HandleAsync(
            [FromBody] UpdateUserRequest request,
            CancellationToken cancellationToken = default)
        {
            var user = await _userManager.FindByIdAsync(request.Id);

            if (user == null)
            {
                return NotFound(new { message = "El usuario no existe." });
            }

            user.Name = request.Name;
            user.SectorId = request.SectorId;
            user.Email = request.Email;
            user.UserName = request.Email;
            user.PhoneNumber = request.PhoneNumber ?? "0000000000";
            user.PhotoUrl = request.PhotoUrl ?? "no_photo_found";
            user.IsActive = request.IsActive;

            var updateResult = await _userManager.UpdateAsync(user);
            if (!updateResult.Succeeded)
            {
                return BadRequest(updateResult.Errors);
            }

            var currentRoles = await _userManager.GetRolesAsync(user);
            var removeResult = await _userManager.RemoveFromRolesAsync(user, currentRoles);

            if (!removeResult.Succeeded)
            {
                return BadRequest(removeResult.Errors);
            }

            if (!string.IsNullOrEmpty(request.Role))
            {
                if (await _roleManager.RoleExistsAsync(request.Role))
                {
                    await _userManager.AddToRoleAsync(user, request.Role);
                }
                else
                {
                    return BadRequest(new { message = $"El rol '{request.Role}' no existe en el sistema." });
                }
            }

            return Ok(new { data = "Usuario actualizado exitosamente." });
        }
    }
}