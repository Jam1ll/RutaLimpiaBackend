using Microsoft.AspNetCore.Http;
using RutaLimpiaBackend.Core.Domain.Entities.Enums;

namespace RutaLimpiaBackend.Core.Application.DTOs
{
    public class ReportResponseDTO
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public string? PhotoUrl { get; set; }
        public required string DirectionReference { get; set; }
        public required decimal Latitude { get; set; }
        public required decimal Longitude { get; set; }
        public ReportType ReportType { get; set; }
        public ReportState ReportState { get; set; }
        public Guid UserId { get; set; }
        public Guid SectorId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}