namespace RutaLimpiaBackend.Core.Application.DTOs.Account.GetAll
{
    public class GetAllUsersResponse
    {
        public required string Id { get; set; }
        public required string Name { get; set; }
        public required string SectorId { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public string? PhotoUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
        public required IEnumerable<string> Roles { get; set; }
    }
}
