using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RutaLimpiaBackend.Core.Application.DTOs.Account.ChangePassword;
using RutaLimpiaBackend.Infrastructure.Identity.Entities;

public class ChangePasswordEndpoint : EndpointBaseAsync
        .WithRequest<ChangePasswordRequest>
        .WithActionResult
{
    private readonly UserManager<User> _userManager;

    public ChangePasswordEndpoint(UserManager<User> userManager)
    {
        _userManager = userManager;
    }

    [HttpPost("api/v1/auth/change-password")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public override async Task<ActionResult> HandleAsync([FromBody] ChangePasswordRequest request, CancellationToken cancellationToken = default)
    {
        var user = await _userManager.FindByIdAsync(request.UserId);

        if (user == null)
        {
            return NotFound(new { message = "Usuario no encontrado." });
        }

        var result = await _userManager.ChangePasswordAsync(user, request.CurrentPassword, request.NewPassword);

        if (!result.Succeeded)
        {
            return BadRequest(result.Errors);
        }

        return Ok(new { message = "Contraseña actualizada exitosamente." });
    }
}