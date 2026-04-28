using RutaLimpiaBackend.Core.Domain.Entities.Common;

namespace RutaLimpiaBackend.Core.Domain.Entities
{
    public class WeatherAlert : AuditableBaseEntity
    {
        public required string Description { get; set; }
        public required decimal RainProbability { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid SectorId { get; set; }

        //nav props
        public Sector? Sector { get; set; }
    }
}
