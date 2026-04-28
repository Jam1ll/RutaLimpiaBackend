namespace RutaLimpiaBackend.Core.Application.DTOs.Account.Google
{
    public class AuthResponse
    {
        public required string Id { get; set; }
        public required string Name { get; set; }
        public required string UserName { get; set; }
        public required string Email { get; set; }
        public required string Token { get; set; }
        public required List<string> Roles { get; set; }
        public required bool IsVerified { get; set; }
    }
}
