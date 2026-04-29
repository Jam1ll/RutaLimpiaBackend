namespace RutaLimpiaBackend.Core.Application.DTOs
{
    public class WeatherAlertResponseDTO
    {
        public Guid Id { get; set; }
        public required string Description { get; set; }
        public required decimal RainProbability { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid SectorId { get; set; }
    }
}