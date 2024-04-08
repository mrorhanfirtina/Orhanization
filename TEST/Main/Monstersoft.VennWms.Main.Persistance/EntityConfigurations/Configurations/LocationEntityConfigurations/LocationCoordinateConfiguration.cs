using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.LocationEntityConfigurations;

public class LocationCoordinateConfiguration : IEntityTypeConfiguration<LocationCoordinate>
{
    public void Configure(EntityTypeBuilder<LocationCoordinate> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("LocationCoordinates").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.LocationId).HasColumnName("LocationId").IsRequired();
        builder.Property(p => p.BuildingId).HasColumnName("BuildingId").IsRequired();
        builder.Property(p => p.LocationX).HasColumnName("LocationX").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.LocationY).HasColumnName("LocationY").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.LocationZ).HasColumnName("LocationZ").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.LocationId, p.BuildingId, p.CreatedDate }, name: "IX_LocationCoordinates_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.Building).WithMany().HasForeignKey(p => p.BuildingId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}