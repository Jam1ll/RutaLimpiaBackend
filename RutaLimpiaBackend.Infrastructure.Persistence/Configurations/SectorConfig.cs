using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Infrastructure.Persistence.Configurations
{
    public class SectorConfig : IEntityTypeConfiguration<Sector>
    {
        public void Configure(EntityTypeBuilder<Sector> builder)
        {
            builder.ToTable("Sectors");
            builder.HasKey(x => x.Id);

            #region PROPERTIES
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Municipality).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(1000);
            #endregion
        }
    }
}
