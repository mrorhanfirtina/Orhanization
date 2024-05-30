using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.OrderEntityConfigurations;

public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("OrderItems", "order").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.OrderId).HasColumnName("OrderId").IsRequired();
        builder.Property(p => p.ProductId).HasColumnName("ProductId").IsRequired();
        builder.Property(p => p.ItemUnitId).HasColumnName("ItemUnitId").IsRequired();
        builder.Property(p => p.Quantity).HasColumnName("Quantity").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.OrderId, p.ProductId, p.ItemUnitId, p.Quantity, p.CreatedDate }, name: "IX_OrderItems_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasMany(p => p.OrderItemMemos).WithOne(p => p.OrderItem).HasForeignKey(p => p.OrderItemId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.OrderItemStockAttrValues).WithOne(p => p.OrderItem).HasForeignKey(p => p.OrderItemId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.OrderShipItems).WithOne(p => p.OrderItem).HasForeignKey(p => p.OrderItemId).OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(p => p.Product).WithMany().HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.ItemUnit).WithMany().HasForeignKey(p => p.ItemUnitId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
