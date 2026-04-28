using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RutaLimpiaBackend.Core.Application.DTOs.Account.GetAll;
using RutaLimpiaBackend.Infrastructure.Identity.Entities;

namespace WebAPI.Account
{
    public class GetAllUsersEndpoint : EndpointBaseAsync
        .WithRequest<GetAllUsersRequest>
        .WithActionResult<IEnumerable<GetAllUsersResponse>>
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public GetAllUsersEndpoint(
            UserManager<User> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet("api/v1/User/All")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(IEnumerable<GetAllUsersResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public override async Task<ActionResult<IEnumerable<GetAllUsersResponse>>> HandleAsync([FromQuery] GetAllUsersRequest request, CancellationToken cancellationToken = default)
        {
            var skip = (request.PageNumber - 1) * request.PageSize;

            var users = await _userManager.Users
                .Skip(skip)
                .Take(request.PageSize)
                .ToListAsync(cancellationToken);

            var responseList = new List<GetAllUsersResponse>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);

                responseList.Add(new GetAllUsersResponse
                {
                    Id = user.Id,
                    Name = user.Name,
                    SectorId = user.SectorId,
                    Email = user.Email ?? "notfound@email.com",
                    PhoneNumber = user.PhoneNumber ?? "0000000000",
                    PhotoUrl = user.PhotoUrl ?? "no_photo_found",
                    CreatedAt = user.CreatedAt,
                    IsActive = user.IsActive,
                    Roles = roles
                });
            }

            return Ok(new { data = responseList });
        }
    }
}