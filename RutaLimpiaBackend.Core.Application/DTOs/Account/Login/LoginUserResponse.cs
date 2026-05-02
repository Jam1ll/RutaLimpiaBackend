namespace RutaLimpiaBackend.Core.Application.DTOs.Account.Login
{
    public class LoginUserResponse
    {
        public string Token { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public IList<string> Roles { get; set; } = new List<string>();
        public Guid SectorId { get; set; }
    }
}
