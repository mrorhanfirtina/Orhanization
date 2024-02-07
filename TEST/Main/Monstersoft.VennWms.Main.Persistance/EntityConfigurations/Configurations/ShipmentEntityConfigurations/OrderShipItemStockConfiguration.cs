using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ShipmentEntityConfigurations;

public class OrderShipItemStockConfiguration : IEntityTypeConfiguration<OrderShipItemStock>
{
    public void Configure(EntityTypeBuilder<OrderShipItemStock> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("OrderShipItemStocks").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.OrderShipItemId).HasColumnName("OrderShipItemId").IsRequired();
        builder.Property(p => p.OrderShipItemTaskId).HasColumnName("OrderShipItemTaskId").IsRequired();
        builder.Property(p => p.StockId).HasColumnName("StockId").IsRequired();
        builder.Property(p => p.Quantity).HasColumnName("Quantity").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.OrderShipItemTask);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
