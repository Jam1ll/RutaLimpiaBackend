using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Infrastructure.Persistence.Configurations
{
    public class TruckConfig : IEntityTypeConfiguration<Truck>
    {
        public void Configure(EntityTypeBuilder<Truck> builder)
        {
            builder.ToTable("Trucks");
            builder.HasKey(x => x.Id);

            #region PROPERTIES
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.LicensePlate).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Capacity).HasColumnType("decimal(18,2)").IsRequired();
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