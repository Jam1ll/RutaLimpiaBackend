using RutaLimpiaBackend.Core.Domain.Entities.Common;
using RutaLimpiaBackend.Core.Domain.Entities.Enums;

namespace RutaLimpiaBackend.Core.Domain.Entities
{
    public class Route : AuditableBaseEntity
    {
        public Guid IdSector { get; set; }
        public required string Number { get; set; }
        public bool IsActive { get; set; }

        //nav props
        public Sector? Sector { get; set; }
    }
}