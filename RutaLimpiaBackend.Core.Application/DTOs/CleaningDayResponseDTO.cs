namespace RutaLimpiaBackend.Core.Application.DTOs
{
    public class CleaningDayResponseDTO
    {
        public Guid Id { get; set; }
        public required string Code { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public required decimal Latitude { get; set; }
        public required decimal Longitude { get; set; }
        public required string SocialNetworkUrl { get; set; }
        public Guid UserId { get; set; }
        public Guid SectorId { get; set; }
    }
}