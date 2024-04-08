using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.LocationEntityConfigurations;

public class LocationDepositorConfiguration : IEntityTypeConfiguration<LocationDepositor>
{
    public void Configure(EntityTypeBuilder<LocationDepositor> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("LocationDepositors").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.LocationId).HasColumnName("LocationId").IsRequired();
        builder.Property(p => p.DepositorId).HasColumnName("DepositorId").IsRequired();
        builder.Property(p => p.IsForbid).HasColumnName("IsForbid").HasDefaultValue(false);
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.LocationId, p.DepositorId, p.CreatedDate }, name: "IX_LocationDepositors_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.Depositor).WithMany().HasForeignKey(p => p.DepositorId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
