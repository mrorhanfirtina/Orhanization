using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ReceiptEntityConfigurations;

public class ReceiptItmStockAttrValueConfiguration : IEntityTypeConfiguration<ReceiptItmStockAttrValue>
{
    public void Configure(EntityTypeBuilder<ReceiptItmStockAttrValue> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("ReceiptItmStockAttrValues").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.ReceiptItemId).HasColumnName("ReceiptItemId").IsRequired();
        builder.Property(p => p.StockAttributeId).HasColumnName("StockAttributeId").IsRequired();
        builder.Property(p => p.Value).HasColumnName("Value").HasMaxLength(120).IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler

        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.ReceiptItem);
        builder.HasOne(p => p.StockAttribute);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
