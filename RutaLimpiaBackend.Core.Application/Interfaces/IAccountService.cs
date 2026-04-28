using RutaLimpiaBackend.Core.Application.DTOs.Account.Google;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Interfaces
{
    public interface IAccountService
    {
        Task<Response<AuthResponse>> AuthenticateGoogleAsync(GoogleLoginRequest request);
    }
}
