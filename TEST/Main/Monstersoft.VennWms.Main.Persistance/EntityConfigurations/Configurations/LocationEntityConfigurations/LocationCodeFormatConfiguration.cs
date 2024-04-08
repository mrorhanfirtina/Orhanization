using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.LocationEntityConfigurations;

public class LocationCodeFormatConfiguration : IEntityTypeConfiguration<LocationCodeFormat>
{
    public void Configure(EntityTypeBuilder<LocationCodeFormat> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("LocationCodeFormats").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.LocationId).HasColumnName("LocationId").IsRequired();
        builder.Property(p => p.Sector).HasColumnName("Sector").IsRequired();
        builder.Property(p => p.SectorCode).HasColumnName("SectorCode").HasMaxLength(30).IsRequired();
        builder.Property(p => p.Column).HasColumnName("Column").IsRequired();
        builder.Property(p => p.ColumnCode).HasColumnName("ColumnCode").HasMaxLength(30).IsRequired();
        builder.Property(p => p.Level).HasColumnName("Level").IsRequired();
        builder.Property(p => p.LevelCode).HasColumnName("LevelCode").HasMaxLength(30).IsRequired();
        builder.Property(p => p.Side).HasColumnName("Side");
        builder.Property(p => p.SideCode).HasColumnName("SideCode").HasMaxLength(30);
        builder.Property(p => p.SubLevel).HasColumnName("SubLevel");
        builder.Property(p => p.SubLevelCode).HasColumnName("SubLevelCode").HasMaxLength(30);
        builder.Property(p => p.SubColumn).HasColumnName("SubColumn");
        builder.Property(p => p.SubColumnCode).HasColumnName("SubColumnCode").HasMaxLength(30);
        builder.Property(p => p.SubPositionCode).HasColumnName("SubPositionCode").HasMaxLength(30);
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.LocationId, p.Sector, p.Column, p.Level, p.Side, p.SubLevel, p.SubColumn, p.CreatedDate }, name: "IX_LocationCodeFormat_Areas");
        #endregion

        #region İlişki Tanımları
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
