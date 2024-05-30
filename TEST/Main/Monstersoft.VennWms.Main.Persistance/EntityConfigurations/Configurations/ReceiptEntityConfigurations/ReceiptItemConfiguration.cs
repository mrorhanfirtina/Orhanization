using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ReceiptEntityConfigurations;

public class ReceiptItemConfiguration : IEntityTypeConfiguration<ReceiptItem>
{
    public void Configure(EntityTypeBuilder<ReceiptItem> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("ReceiptItems", "receipt").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.ReceiptId).HasColumnName("ReceiptId").IsRequired();
        builder.Property(p => p.ProductId).HasColumnName("ProductId").IsRequired();
        builder.Property(p => p.ItemUnitId).HasColumnName("ItemUnitId").IsRequired();
        builder.Property(p => p.StatusId).HasColumnName("StatusId").IsRequired();
        builder.Property(p => p.ExpectedQuantity).HasColumnName("ExpectedQuantity").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.ActualQuantity).HasColumnName("ActualQuantity").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.ReceiptId, p.ProductId, p.ItemUnitId, p.StatusId, p.ExpectedQuantity, p.ActualQuantity, p.CreatedDate }, name: "IX_ReceiptItems_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasMany(p => p.ReceiptItemMemos).WithOne(p => p.ReceiptItem).HasForeignKey(p => p.ReceiptItemId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.ReceiptItmStockAttrValues).WithOne(p => p.ReceiptItem).HasForeignKey(p => p.ReceiptItemId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(p => p.Product).WithMany().HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.ItemUnit).WithMany().HasForeignKey(p => p.ItemUnitId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.Status).WithMany().HasForeignKey(p => p.StatusId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
