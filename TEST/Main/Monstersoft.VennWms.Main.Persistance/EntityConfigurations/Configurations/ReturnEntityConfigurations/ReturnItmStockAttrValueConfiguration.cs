using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ReturnEntityConfigurations;

public class ReturnItmStockAttrValueConfiguration : IEntityTypeConfiguration<ReturnItmStockAttrValue>
{
    public void Configure(EntityTypeBuilder<ReturnItmStockAttrValue> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("ReturnItmStockAttrValues", "return").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.ReturnItemId).HasColumnName("ReturnItemId").IsRequired();
        builder.Property(p => p.StockAttributeId).HasColumnName("StockAttributeId").IsRequired();
        builder.Property(p => p.Value).HasColumnName("Value").HasMaxLength(120).IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.ReturnItemId, p.StockAttributeId, p.Value, p.CreatedDate }, name: "IX_ReturnItmStockAttrValues_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.StockAttribute).WithMany().HasForeignKey(p => p.StockAttributeId).OnDelete(DeleteBehavior.Restrict);

        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
