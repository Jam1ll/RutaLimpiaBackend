using Google.Apis.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using RutaLimpiaBackend.Core.Application.DTOs.Account.Google;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities.Enums;
using RutaLimpiaBackend.Core.Domain.Settings;
using RutaLimpiaBackend.Infrastructure.Identity.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RutaLimpiaBackend.Infrastructure.Identity.Services
{
    public class AccountService : IAccountService
    {
        private readonly JWTSettings _jwtSettings;
        private readonly GoogleSettings _googleSettings;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountService(JWTSettings jwtSettings, GoogleSettings googleSettings, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _jwtSettings = jwtSettings;
            _googleSettings = googleSettings;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<Core.Application.Wrappers.Response<AuthResponse>> AuthenticateGoogleAsync(GoogleLoginRequest request)
        {
            GoogleJsonWebSignature.Payload payload;

            //
            // validar token con Google
            //

            try
            {
                var settings = new GoogleJsonWebSignature.ValidationSettings
                {
                    Audience = new List<string> { _googleSettings.ClientID }
                };
                // validar firma criptografica y expiracion
                payload = await GoogleJsonWebSignature.ValidateAsync(request.IdToken, settings);
            }
            catch (Exception e)
            {
                return new Core.Application.Wrappers.Response<AuthResponse>($"Error validating google token: {e.Message}");
            }

            // buscar usuario validado por Google en la base de datos
            var user = await _userManager.FindByEmailAsync(payload.Email);

            if (user == null)
            {
                // registro silencioso
                user = new User
                {
                    Name = payload.GivenName ?? "not_found_name",
                    UserName = payload.Email ?? "not_found_userName",
                    Email = payload.Email,
                    EmailConfirmed = true,
                    SectorId = "not_found_sector"
                };

                var result = await _userManager.CreateAsync(user);

                if (!result.Succeeded)
                {
                    var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                    return new Core.Application.Wrappers.Response<AuthResponse>($"Error creating user: {errors}");
                }

                await _userManager.AddToRoleAsync(user, Roles.CITIZEN.ToString());
            }

            //
            // generar token 
            //

            var token = await GenerateJWTToken(user);

            var authResponse = new AuthResponse
            {
                Id = user.Id,
                Name = user.Name,
                UserName = user.UserName ?? "not_found_userName",
                Email = user.Email ?? "not_found_email@gmail.com",
                Token = token,
                Roles = (await _userManager.GetRolesAsync(user)).ToList(),
                IsVerified = user.EmailConfirmed
            };

            return new Core.Application.Wrappers.Response<AuthResponse>(authResponse, "Authenticated Successfully");
        }

        // helper
        private async Task<string> GenerateJWTToken(User user)
        {
            //claims basicos (info contenida en el token)
            var userClaims = await _userManager.GetClaimsAsync(user);
            var roles = await _userManager.GetRolesAsync(user);

            var claims = new List<Claim>
            {
                new(JwtRegisteredClaimNames.Sub, user.UserName ?? "not_found_userName"),
                new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new(JwtRegisteredClaimNames.Email, user.Email ?? "not_found_email@gmail.com"),
                new("uid", user.Id)
            };

            //agregar roles a los claims
            foreach (var role in roles)
            {
                claims.Add(new("roles", role));
            }

            claims.AddRange(userClaims);

            //firmar token con clave secreta
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(_jwtSettings.DurationInMinutes),
                Issuer = _jwtSettings.Issuer,
                Audience = _jwtSettings.Audience,
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var jwt = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(jwt);
        }
    }
}
