using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Infrastructure.Persistence.Configurations
{
    public class CleaningDayConfig : IEntityTypeConfiguration<CleaningDay>
    {
        public void Configure(EntityTypeBuilder<CleaningDay> builder)
        {
            builder.ToTable("CleaningDays");
            builder.HasKey(x => x.Id);

            #region PROPERTIES
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Code).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Title).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.StartDate).IsRequired();
            builder.Property(x => x.EndDate).IsRequired();
            builder.Property(x => x.Latitude).HasColumnType("decimal(18,8)").IsRequired();
            builder.Property(x => x.Longitude).HasColumnType("decimal(18,8)").IsRequired();
            builder.Property(x => x.SocialNetworkUrl).HasMaxLength(500).IsRequired();
            builder.Property(x => x.UserId).IsRequired();
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