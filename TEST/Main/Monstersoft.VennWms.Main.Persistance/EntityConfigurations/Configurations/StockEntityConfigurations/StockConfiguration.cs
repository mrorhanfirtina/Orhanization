using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.StockEntityConfigurations;

public class StockConfiguration : IEntityTypeConfiguration<Stock>
{
    public void Configure(EntityTypeBuilder<Stock> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("Stocks").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.StockContainerId).HasColumnName("StockContainerId").IsRequired();
        builder.Property(p => p.ProductId).HasColumnName("ProductId").IsRequired();
        builder.Property(p => p.DepositorId).HasColumnName("DepositorId").IsRequired();
        builder.Property(p => p.LocationId).HasColumnName("LocationId").IsRequired();
        builder.Property(p => p.UnitId).HasColumnName("UnitId").IsRequired();
        builder.Property(p => p.ReceiptId).HasColumnName("ReceiptId");
        builder.Property(p => p.ReturnId).HasColumnName("ReturnId");
        builder.Property(p => p.Quantity).HasColumnName("Quantity").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.FreeQuantity).HasColumnName("FreeQuantity").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.StockContainer);
        builder.HasOne(p => p.Product);
        builder.HasOne(p => p.Location);
        builder.HasOne(p => p.Unit);
        builder.HasOne(p => p.Receipt);
        builder.HasOne(p => p.Return);
        builder.HasMany(p => p.WorkTasks);
        builder.HasMany(p => p.StockAttributeValues);
        builder.HasMany(p => p.StockMemos);
        builder.HasMany(p => p.StockReserveReasons);
        builder.HasMany(p => p.StockUnsuitReasons);
        builder.HasMany(p => p.TaskStocks);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
