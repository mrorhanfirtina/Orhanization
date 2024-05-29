using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ProductEntityConfigurations;

public class ProductStockAttributeConfiguration : IEntityTypeConfiguration<ProductStockAttribute>
{
    public void Configure(EntityTypeBuilder<ProductStockAttribute> builder)
    {

        #region Tablo Tanımları
        builder.ToTable("ProductStockAttributes", "product").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.ProductId).HasColumnName("ProductId").IsRequired();
        builder.Property(p => p.StockAttributeId).HasColumnName("StockAttributeId").IsRequired();
        builder.Property(p => p.IsNecessary).HasColumnName("IsNecessary").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion


        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.ProductId, p.StockAttributeId, p.CreatedDate }, name: "IX_ProductStockAttributes_Areas");
        #endregion


        #region İlişki Tanımları
        builder.HasOne(p => p.StockAttribute).WithMany().HasForeignKey(p => p.StockAttributeId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion

    }
}
