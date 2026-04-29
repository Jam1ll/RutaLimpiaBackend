namespace RutaLimpiaBackend.Core.Application.DTOs
{
    public class CollectionScheduleResponseDTO
    {
        public Guid Id { get; set; }
        public Guid RouteId { get; set; }
        public required string Weekday { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public bool IsActive { get; set; }
    }
}