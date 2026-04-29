namespace RutaLimpiaBackend.Core.Application.DTOs
{
    public class LocationUpdateDTO
    {
        public required string RouteId { get; set; }
        public required decimal Latitude { get; set; }
        public required decimal Longitude { get; set; }
    }
}