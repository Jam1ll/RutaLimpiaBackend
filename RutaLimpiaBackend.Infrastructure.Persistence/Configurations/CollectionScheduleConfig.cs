using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Infrastructure.Persistence.Configurations
{
    public class CollectionScheduleConfig : IEntityTypeConfiguration<CollectionSchedule>
    {
        public void Configure(EntityTypeBuilder<CollectionSchedule> builder)
        {
            builder.ToTable("CollectionSchedules");
            builder.HasKey(x => x.Id);

            #region PROPERTIES
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Weekday).HasMaxLength(20).IsRequired();
            builder.Property(x => x.StartTime).IsRequired();
            builder.Property(x => x.EndTime).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            #endregion

            #region RELATIONSHIPS
            builder.HasOne(x => x.Route)
                   .WithMany()
                   .HasForeignKey(x => x.RouteId)
                   .OnDelete(DeleteBehavior.Restrict);
            #endregion
        }
    }
}