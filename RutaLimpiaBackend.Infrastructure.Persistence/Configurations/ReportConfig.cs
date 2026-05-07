using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Infrastructure.Persistence.Configurations
{
    public class ReportConfig : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder.ToTable("Reports");
            builder.HasKey(x => x.Id);

            #region PROPERTIES
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Title).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.DirectionReference).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Latitude).HasColumnType("decimal(18,8)").IsRequired();
            builder.Property(x => x.Longitude).HasColumnType("decimal(18,8)").IsRequired();
            builder.Property(x => x.ReportType).HasConversion<int>().IsRequired();
            builder.Property(x => x.ReportState).HasConversion<int>().IsRequired();
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