using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.LocationEntityConfigurations;

public class LocationDimensionConfiguration : IEntityTypeConfiguration<LocationDimension>
{
    public void Configure(EntityTypeBuilder<LocationDimension> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("LocationDimensions").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.LocationId).HasColumnName("LocationId").IsRequired();
        builder.Property(p => p.Width).HasColumnName("Width").HasColumnType("DECIMAL(18,6)");
        builder.Property(p => p.Height).HasColumnName("Height").HasColumnType("DECIMAL(18,6)");
        builder.Property(p => p.Length).HasColumnName("Length").HasColumnType("DECIMAL(18,6)");
        builder.Property(p => p.LengthUnitId).HasColumnName("LengthUnitId");
        builder.Property(p => p.Volume).HasColumnName("Volume").HasColumnType("DECIMAL(18,6)");
        builder.Property(p => p.VolumeUnitId).HasColumnName("VolumeUnitId");
        builder.Property(p => p.MaxWeight).HasColumnName("MaxWeight").HasColumnType("DECIMAL(18,6)");
        builder.Property(p => p.WeightUnitId).HasColumnName("WeightUnitId");
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler    
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.LocationId, p.LengthUnitId, p.VolumeUnitId, p.WeightUnitId, p.CreatedDate }, name: "IX_LocationDimensions_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.LengthUnit).WithMany().HasForeignKey(p => p.LengthUnitId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.VolumeUnit).WithMany().HasForeignKey(p => p.VolumeUnitId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.WeightUnit).WithMany().HasForeignKey(p => p.WeightUnitId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
