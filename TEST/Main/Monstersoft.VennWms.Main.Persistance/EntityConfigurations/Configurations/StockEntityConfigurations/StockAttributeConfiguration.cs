using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.StockEntityConfigurations;

public class StockAttributeConfiguration : IEntityTypeConfiguration<StockAttribute>
{
    public void Configure(EntityTypeBuilder<StockAttribute> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("StockAttributes").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
        builder.Property(p => p.Description).HasColumnName("Description").HasMaxLength(60).IsRequired();
        builder.Property(p => p.DepositorId).HasColumnName("DepositorId").IsRequired();
        builder.Property(p => p.AttributeInputTypeId).HasColumnName("AttributeInputTypeId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(indexExpression: p => p.Code, name: "UK_StockAttributes_Code").IsUnique();
        builder.HasIndex(indexExpression: p => p.Description, name: "UK_StockAttributes_Description").IsUnique();
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.AttributeInputType);
        builder.HasMany(p => p.LogStockAttributeValues);
        builder.HasMany(p => p.OrderItemStockAttrValues);
        builder.HasMany(p => p.ReceiptItmStockAttrValues);
        builder.HasMany(p => p.ReturnItmStockAttrValues);
        builder.HasMany(p => p.StockAttributeValues);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
