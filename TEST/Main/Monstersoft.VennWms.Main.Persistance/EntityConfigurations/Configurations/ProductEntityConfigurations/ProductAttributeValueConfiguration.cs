using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ProductEntityConfigurations;

public class ProductAttributeValueConfiguration : IEntityTypeConfiguration<ProductAttributeValue>
{
    public void Configure(EntityTypeBuilder<ProductAttributeValue> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("ProductAttributeValues").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.ProductId).HasColumnName("ProductId").IsRequired();
        builder.Property(p => p.ProductAttributeId).HasColumnName("ProductAttributeId").IsRequired();
        builder.Property(p => p.Value).HasColumnName("Value").HasMaxLength(120).IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.ProductId, p.ProductAttributeId, p.Value, p.CreatedDate }, name: "IX_ProductAttributeValues_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.ProductAttribute).WithMany().HasForeignKey(p => p.ProductAttributeId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
