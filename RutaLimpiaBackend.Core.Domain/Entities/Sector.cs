using RutaLimpiaBackend.Core.Domain.Entities.Common;

namespace RutaLimpiaBackend.Core.Domain.Entities
{
    public class Sector : AuditableBaseEntity
    {
        public required string Name { get; set; }
        public required string Municipality { get; set; }
        public string? Description { get; set; }
    }
}
