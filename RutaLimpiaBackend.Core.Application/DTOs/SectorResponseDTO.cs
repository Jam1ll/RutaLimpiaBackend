namespace RutaLimpiaBackend.Core.Application.DTOs
{
    public class SectorResponseDTO
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Municipality { get; set; }
        public string? Description { get; set; }
    }
}
