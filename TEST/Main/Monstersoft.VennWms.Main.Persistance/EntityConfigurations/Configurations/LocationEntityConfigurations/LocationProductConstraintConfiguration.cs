using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.LocationEntityConfigurations;

public class LocationProductConstraintConfiguration : IEntityTypeConfiguration<LocationProductConstraint>
{
    public void Configure(EntityTypeBuilder<LocationProductConstraint> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("LocationProductConstraints", "location").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.LocationId).HasColumnName("LocationId").IsRequired();
        builder.Property(p => p.ItemUnitId).HasColumnName("UnitId").IsRequired();
        builder.Property(p => p.Capacity).HasColumnName("Capacity").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.ReplenishmentTreshold).HasColumnName("ReplenishmentTreshold").HasColumnType("DECIMAL(6,3)");
        builder.Property(p => p.ExceedCapacityMargin).HasColumnName("ExceedCapacityMargin").HasColumnType("DECIMAL(6,3)");
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.LocationId, p.ItemUnitId, p.CreatedDate }, name: "IX_LocationProductConstraints_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.ItemUnit).WithMany().HasForeignKey(p => p.ItemUnitId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
