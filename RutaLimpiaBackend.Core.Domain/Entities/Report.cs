using RutaLimpiaBackend.Core.Domain.Entities.Common;
using RutaLimpiaBackend.Core.Domain.Entities.Enums;

namespace RutaLimpiaBackend.Core.Domain.Entities
{
    public class Report : AuditableBaseEntity
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string PhotoUrl { get; set; }
        public required string DirectionReference { get; set; }
        public required decimal Latitude { get; set; }
        public required decimal Longitude { get; set; }
        public ReportType ReportType { get; set; } 
        public ReportState ReportState { get; set; }
        public Guid UserId { get; set; }
        public Guid SectorId { get; set; }

        //nav props
        public Route? Route { get; set; }
        public Sector? Sector { get; set; }
    }
}
