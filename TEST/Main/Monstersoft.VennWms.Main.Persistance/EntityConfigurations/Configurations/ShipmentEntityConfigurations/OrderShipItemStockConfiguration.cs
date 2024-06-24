using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ShipmentEntityConfigurations;

public class OrderShipItemStockConfiguration : IEntityTypeConfiguration<OrderShipItemStock>
{
    public void Configure(EntityTypeBuilder<OrderShipItemStock> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("OrderShipItemStocks", "shipment").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.OrderShipItemId).HasColumnName("OrderShipItemId").IsRequired();
        builder.Property(p => p.OrderShipItemTaskId).HasColumnName("OrderShipItemTaskId").IsRequired();
        builder.Property(p => p.StockId).HasColumnName("StockId").IsRequired();
        builder.Property(p => p.StockPackTypeId).HasColumnName("StockPackTypeId").IsRequired();
        builder.Property(p => p.Quantity).HasColumnName("Quantity").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.OrderShipItemId, p.OrderShipItemTaskId, p.StockId, p.StockPackTypeId, p.Quantity, p.CreatedDate }, name: "IX_OrderShipItemStocks_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.Stock).WithMany().HasForeignKey(p => p.StockId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.StockPackType).WithMany().HasForeignKey(p => p.StockPackTypeId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.OrderShipItem).WithMany().HasForeignKey(p => p.OrderShipItemId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
