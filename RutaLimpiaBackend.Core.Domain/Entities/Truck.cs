using RutaLimpiaBackend.Core.Domain.Entities.Common;

namespace RutaLimpiaBackend.Core.Domain.Entities
{
    public class Truck : AuditableBaseEntity
    {
        public Guid IdRoute { get; set; }
        public required string LicensePlate { get; set; }
        public decimal Capacity { get; set; }
        public bool IsActive { get; set; }

        //nav props
        public Route? Route { get; set; }
    }
}
