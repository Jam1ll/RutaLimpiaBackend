using RutaLimpiaBackend.Core.Domain.Entities.Common;

namespace RutaLimpiaBackend.Core.Domain.Entities
{
    public class CollectionSchedule : AuditableBaseEntity
    {
        public Guid RouteId { get; set; }
        public required string Weekday { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public bool IsActive { get; set; }

        //nav props
        public Route? Route { get; set; }
    }
}
