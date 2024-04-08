using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.LocationEntityConfigurations;

public class LocationProductConstraintConfiguration : IEntityTypeConfiguration<LocationProductConstraint>
{
    public void Configure(EntityTypeBuilder<LocationProductConstraint> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("LocationProductConstraints").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.LocationId).HasColumnName("LocationId").IsRequired();
        builder.Property(p => p.ProductId).HasColumnName("ProductId").IsRequired();
        builder.Property(p => p.UnitId).HasColumnName("UnitId").IsRequired();
        builder.Property(p => p.Capacity).HasColumnName("Capacity").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.ReplenishmentTreshold).HasColumnName("ReplenishmentTreshold").HasColumnType("DECIMAL(6,3)");
        builder.Property(p => p.ExceedCapacityMargin).HasColumnName("ExceedCapacityMargin").HasColumnType("DECIMAL(6,3)");
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.LocationId, p.ProductId, p.UnitId, p.CreatedDate }, name: "IX_LocationProductConstraints_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.Product).WithMany().HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.Unit).WithMany().HasForeignKey(p => p.UnitId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
