using RutaLimpiaBackend.Core.Domain.Entities.Common;

namespace RutaLimpiaBackend.Core.Domain.Entities
{
    public class CleaningDayParticipation : AuditableBaseEntity
    {
        public required string Comment { get; set; }
        public Guid CleaningDayId { get; set; }
        public Guid UserId { get; set; }

        //nav props
        public CleaningDay? CleaningDay { get; set; }
    }
}
