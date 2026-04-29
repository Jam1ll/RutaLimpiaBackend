namespace RutaLimpiaBackend.Core.Application.DTOs.Account.Register
{
    public class RegisterUserResponse
    {
        public string UserId { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public List<string> Errors { get; set; } = new List<string>();
        public bool Success { get; set; }
    }
}
