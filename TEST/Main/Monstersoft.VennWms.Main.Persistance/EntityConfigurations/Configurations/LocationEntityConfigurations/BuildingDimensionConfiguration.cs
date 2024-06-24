using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.LocationEntityConfigurations;

public class BuildingDimensionConfiguration : IEntityTypeConfiguration<BuildingDimension>
{
    public void Configure(EntityTypeBuilder<BuildingDimension> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("BuildingDimensions", "location").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.BuildingId).HasColumnName("BuildingId").IsRequired();
        builder.Property(p => p.LenghtUnitId).HasColumnName("LenghtUnitId").IsRequired();
        builder.Property(p => p.BuildingLevel).HasColumnName("BuildingLevel");
        builder.Property(p => p.Width).HasColumnName("Width").HasColumnType("DECIMAL(18,6)");
        builder.Property(p => p.Height).HasColumnName("Height").HasColumnType("DECIMAL(18,6)");
        builder.Property(p => p.Length).HasColumnName("Length").HasColumnType("DECIMAL(18,6)");
        builder.Property(p => p.VolumeUnitId).HasColumnName("VolumeUnitId").IsRequired();
        builder.Property(p => p.Volume).HasColumnName("Volume").HasColumnType("DECIMAL(18,6)");
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.BuildingId, p.LenghtUnitId, p.BuildingLevel, p.VolumeUnitId, p.CreatedDate }, name: "IX_BuildingDimensions_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.LenghtUnit).WithMany().HasForeignKey(p => p.LenghtUnitId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.VolumeUnit).WithMany().HasForeignKey(p => p.VolumeUnitId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
