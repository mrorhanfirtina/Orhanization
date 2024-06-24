using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.LocationEntityConfigurations;

public class LocationFeatureConfiguration : IEntityTypeConfiguration<LocationFeature>
{
    public void Configure(EntityTypeBuilder<LocationFeature> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("LocationFeatures", "location").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.LocationId).HasColumnName("LocationId").IsRequired();
        builder.Property(p => p.StockControlLed).HasColumnName("StockControlLed").HasDefaultValue(false);
        builder.Property(p => p.ReceivingLed).HasColumnName("ReceivingLed").HasDefaultValue(false);
        builder.Property(p => p.SendingLed).HasColumnName("SendingLed").HasDefaultValue(false);
        builder.Property(p => p.DamagedLed).HasColumnName("DamagedLed").HasDefaultValue(false);
        builder.Property(p => p.ReturnsLed).HasColumnName("ReturnsLed").HasDefaultValue(false);
        builder.Property(p => p.PackingLed).HasColumnName("PackingLed").HasDefaultValue(false);
        builder.Property(p => p.SortingLed).HasColumnName("SortingLed").HasDefaultValue(false);
        builder.Property(p => p.PickingLed).HasColumnName("PickingLed").HasDefaultValue(false);
        builder.Property(p => p.RepackingLed).HasColumnName("RepackingLed").HasDefaultValue(false);
        builder.Property(p => p.ReplenishSourceLed).HasColumnName("ReplenishSourceLed").HasDefaultValue(false);
        builder.Property(p => p.ReplenishTargetLed).HasColumnName("ReplenishTargetLed").HasDefaultValue(false);
        builder.Property(p => p.NoStockMergeLed).HasColumnName("NoStockMergeLed").HasDefaultValue(false);
        builder.Property(p => p.SingleProductLed).HasColumnName("SingleProductLed").HasDefaultValue(false);
        builder.Property(p => p.SinglePackTypeLed).HasColumnName("SinglePackTypeLed").HasDefaultValue(false);
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.LocationId, p.CreatedDate }, name: "IX_LocationFeatures_Areas");
        #endregion

        #region İlişki Tanımları

        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
