using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Infrastructure.Persistence.Configurations
{
    public class CleaningDayParticipationConfig : IEntityTypeConfiguration<CleaningDayParticipation>
    {
        public void Configure(EntityTypeBuilder<CleaningDayParticipation> builder)
        {
            builder.ToTable("CleaningDayParticipations");
            builder.HasKey(x => x.Id);

            #region PROPERTIES
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Comment).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.UserId).IsRequired();
            #endregion

            #region RELATIONSHIPS
            builder.HasOne(x=>x.CleaningDay)
                   .WithMany()
                   .HasForeignKey(x => x.CleaningDayId)
                   .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}