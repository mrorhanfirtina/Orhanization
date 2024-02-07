using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ProductEntityConfigurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("Products").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
        builder.Property(p => p.Description).HasColumnName("Description").HasMaxLength(120).IsRequired();
        builder.Property(p => p.AlternativeCode).HasColumnName("AlternativeCode").HasMaxLength(30);
        builder.Property(p => p.DepositorId).HasColumnName("DepositorId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        //Kod kısmı business rules tarafında yazılacak. Code, Description, AlternativeCode farklı depositorlarda aynı kod olabilir cunku.
        #endregion

        #region İlişki Tanımları
        builder.HasMany(p => p.ProductAttributeValues);
        builder.HasMany(p => p.OrderItems);
        builder.HasMany(p => p.LogStocks);
        builder.HasMany(p => p.ReceiptItems);
        builder.HasMany(p => p.ReturnItems);
        builder.HasMany(p => p.Stocks);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
