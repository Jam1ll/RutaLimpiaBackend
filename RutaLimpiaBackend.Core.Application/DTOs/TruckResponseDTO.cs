namespace RutaLimpiaBackend.Core.Application.DTOs
{
    public class TruckResponseDTO
    {
        public Guid Id { get; set; }
        public Guid RouteId { get; set; }
        public required string LicensePlate { get; set; }
        public decimal Capacity { get; set; }
        public bool IsActive { get; set; }
    }
}