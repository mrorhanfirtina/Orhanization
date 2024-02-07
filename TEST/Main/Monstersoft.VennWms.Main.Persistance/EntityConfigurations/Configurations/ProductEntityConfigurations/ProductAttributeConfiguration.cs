using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ProductEntityConfigurations;

public class ProductAttributeConfiguration : IEntityTypeConfiguration<ProductAttribute>
{
    public void Configure(EntityTypeBuilder<ProductAttribute> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("ProductAttributes").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
        builder.Property(p => p.Description).HasColumnName("Description").HasMaxLength(60).IsRequired();
        builder.Property(p => p.AttributeInputTypeId).HasColumnName("AttributeInputTypeId").IsRequired();
        builder.Property(p => p.DepositorId).HasColumnName("DepositorId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(indexExpression: p => p.Code, name: "UK_ProductAttributes_Code").IsUnique();
        builder.HasIndex(indexExpression: p => p.Description, name: "UK_ProductAttributes_Description").IsUnique();
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.AttributeInputType);
        builder.HasMany(p => p.ProductAttributeValues);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
