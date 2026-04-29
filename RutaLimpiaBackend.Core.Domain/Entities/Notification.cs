using RutaLimpiaBackend.Core.Domain.Entities.Common;
using RutaLimpiaBackend.Core.Domain.Entities.Enums;

namespace RutaLimpiaBackend.Core.Domain.Entities
{
    public class Notification : AuditableBaseEntity
    {
        public required string Title { get; set; }
        public required string Message { get; set; }
        public required NotificationType NotificationType { get; set; }
        public bool IsRead { get; set; }
    }
}
