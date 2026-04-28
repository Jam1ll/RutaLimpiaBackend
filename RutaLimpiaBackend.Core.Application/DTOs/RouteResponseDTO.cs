namespace RutaLimpiaBackend.Core.Application.DTOs
{
    public class RouteResponseDTO
    {
        public Guid Id { get; set; }
        public Guid SectorId { get; set; }
        public required string Number { get; set; }
        public bool IsActive { get; set; }
    }
}