namespace RutaLimpiaBackend.Core.Application.DTOs
{
    public class CleaningDayParticipationResponseDTO
    {
        public Guid Id { get; set; }
        public required string Comment { get; set; }
        public Guid CleaningDayId { get; set; }
        public Guid UserId { get; set; }
    }
}