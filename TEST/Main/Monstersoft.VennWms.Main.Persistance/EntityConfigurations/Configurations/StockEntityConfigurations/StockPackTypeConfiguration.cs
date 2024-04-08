using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.StockEntityConfigurations;

public class StockPackTypeConfiguration : IEntityTypeConfiguration<StockPackType>
{
    public void Configure(EntityTypeBuilder<StockPackType> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("StockPackTypes").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.StockId).HasColumnName("StockId").IsRequired();
        builder.Property(p => p.ItemUnitId).HasColumnName("ItemUnitId").IsRequired();
        builder.Property(p => p.Quantity).HasColumnName("Quantity").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.QuantityFree).HasColumnName("QuantityFree").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.CUQuantity).HasColumnName("CUQuantity").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.CUQuantityFree).HasColumnName("CUQuantityFree").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.PackTypeRatio).HasColumnName("PackTypeRatio").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.StockId, p.ItemUnitId, p.Quantity, p.QuantityFree, p.CUQuantity, p.CUQuantityFree, p.PackTypeRatio, p.CreatedDate }, name: "IX_StockPackTypes_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.Stock).WithMany().HasForeignKey(p => p.StockId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(p => p.ItemUnit).WithMany().HasForeignKey(p => p.ItemUnitId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
