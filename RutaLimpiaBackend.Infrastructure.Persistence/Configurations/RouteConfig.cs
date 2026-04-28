using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Infrastructure.Persistence.Configurations
{
    public class RouteConfig : IEntityTypeConfiguration<Route>
    {
        public void Configure(EntityTypeBuilder<Route> builder)
        {
            builder.ToTable("Routes");
            builder.HasKey(x => x.Id);

            #region PROPERTIES
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Number).HasMaxLength(100).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            #endregion

            #region RELATIONSHIPS
            builder.HasOne(x => x.Sector)
                   .WithMany()
                   .HasForeignKey(x => x.Sector)
                   .OnDelete(DeleteBehavior.Restrict);
            #endregion
        }
    }
}