using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.LocationEntityConfigurations;

public class LocationStockAttributeConfiguration : IEntityTypeConfiguration<LocationStockAttribute>
{
    public void Configure(EntityTypeBuilder<LocationStockAttribute> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("LocationStockAttributes").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.LocationId).HasColumnName("LocationId").IsRequired();
        builder.Property(p => p.StockAttributeId).HasColumnName("StockAttributeId").IsRequired();
        builder.Property(p => p.Value).HasColumnName("Value").HasMaxLength(60).IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.LocationId, p.StockAttributeId, p.CreatedDate }, name: "IX_LocationStockAttributes_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.StockAttribute).WithMany().HasForeignKey(p => p.StockAttributeId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
