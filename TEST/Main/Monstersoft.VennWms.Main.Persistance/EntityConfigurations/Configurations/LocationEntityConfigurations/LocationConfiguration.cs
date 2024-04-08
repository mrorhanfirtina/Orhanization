using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.LocationEntityConfigurations;

public class LocationConfiguration : IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("Locations").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
        builder.Property(p => p.Description).HasColumnName("Description").HasMaxLength(120).IsRequired();
        builder.Property(p => p.StorageSystemId).HasColumnName("StorageSystemId").IsRequired();
        builder.Property(p => p.DepositorCompanyId).HasColumnName("DepositorCompanyId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.Code, p.Description, p.StorageSystemId, p.DepositorCompanyId, p.CreatedDate }, name: "IX_Locations_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.DepositorCompany).WithMany().HasForeignKey(p => p.DepositorCompanyId).OnDelete(DeleteBehavior.Restrict);
        builder.HasMany(p => p.LocationStockAttributes).WithOne().HasForeignKey(p => p.LocationId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.LocationProducts).WithOne().HasForeignKey(p => p.LocationId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.LocationZones).WithOne().HasForeignKey(p => p.LocationId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.LocationProductAttributes).WithOne().HasForeignKey(p => p.LocationId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(p => p.LocationLockReason).WithOne().HasForeignKey<LocationLockReason>(p => p.LocationId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(p => p.LocationPickingType).WithOne().HasForeignKey<LocationPickingType>(p => p.LocationId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(p => p.LocationDimension).WithOne().HasForeignKey<LocationDimension>(p => p.LocationId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(p => p.LocationFeature).WithOne().HasForeignKey<LocationFeature>(p => p.LocationId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(p => p.LocationPriority).WithOne().HasForeignKey<LocationPriority>(p => p.LocationId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(p => p.LocationCodeFormat).WithOne().HasForeignKey<LocationCodeFormat>(p => p.LocationId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(p => p.LocationCoordinate).WithOne().HasForeignKey<LocationCoordinate>(p => p.LocationId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.LocationUnitConstraints).WithOne().HasForeignKey(p => p.LocationId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.LocationDepositors).WithOne().HasForeignKey(p => p.LocationId).OnDelete(DeleteBehavior.Cascade);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
