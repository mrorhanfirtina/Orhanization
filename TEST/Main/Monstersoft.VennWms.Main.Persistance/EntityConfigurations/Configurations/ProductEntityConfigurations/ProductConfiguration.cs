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
        builder.Property(p => p.DepositorCompanyId).HasColumnName("DepositorCompanyId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.Code, p.Description, p.AlternativeCode, p.DepositorCompanyId, p.CreatedDate }, name: "IX_Products_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasMany(p => p.ProductAttributeValues).WithOne().HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.ProductBarcodes).WithOne().HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.ItemUnits).WithOne().HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.ProductDepositors).WithOne().HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.ProductStockAttributes).WithOne().HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(p => p.DepositorCompany).WithMany().HasForeignKey(p => p.DepositorCompanyId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
