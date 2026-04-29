using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Infrastructure.Persistence.Configurations
{
    public class WeatherAlertConfig : IEntityTypeConfiguration<WeatherAlert>
    {
        public void Configure(EntityTypeBuilder<WeatherAlert> builder)
        {
            builder.ToTable("WeatherAlerts");
            builder.HasKey(x => x.Id);

            #region PROPERTIES
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.RainProbability).HasColumnType("decimal(5,2)").IsRequired();
            builder.Property(x => x.StartDate).IsRequired();
            builder.Property(x => x.EndDate).IsRequired();
            #endregion

            #region RELATIONSHIPS
            builder.HasOne(x => x.Sector)
                   .WithMany()
                   .HasForeignKey(x => x.SectorId)
                   .OnDelete(DeleteBehavior.Restrict);
            #endregion
        }
    }
}