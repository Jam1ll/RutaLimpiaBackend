using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Infrastructure.Persistence.Configurations
{
    public class NotificationConfig : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.ToTable("Notifications");
            builder.HasKey(x => x.Id);

            #region PROPERTIES
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Title).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Message).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.NotificationType).HasConversion<int>().IsRequired();
            builder.Property(x => x.IsRead).IsRequired();
            #endregion
        }
    }
}