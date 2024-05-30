using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ReturnEntityConfigurations;

public class ReturnItemConfiguration : IEntityTypeConfiguration<ReturnItem>
{
    public void Configure(EntityTypeBuilder<ReturnItem> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("ReturnItems", "return").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.ReturnId).HasColumnName("ReturnId").IsRequired();
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
        builder.HasIndex(p => new { p.ReturnId, p.ProductId, p.ItemUnitId, p.StatusId, p.ExpectedQuantity, p.ActualQuantity, p.CreatedDate }, name: "IX_ReturnItems_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasMany(p => p.ReturnItemMemos).WithOne(p => p.ReturnItem).HasForeignKey(p => p.ReturnItemId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.ReturnItmStockAttrValues).WithOne(p => p.ReturnItem).HasForeignKey(p => p.ReturnItemId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(p => p.Product).WithMany().HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.ItemUnit).WithMany().HasForeignKey(p => p.ItemUnitId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.Status).WithMany().HasForeignKey(p => p.StatusId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
