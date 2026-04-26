namespace RutaLimpiaBackend.Core.Domain.Entities.Common
{
    public abstract class AuditableBaseEntity : IEntity
    {
        public virtual Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
    }
}
