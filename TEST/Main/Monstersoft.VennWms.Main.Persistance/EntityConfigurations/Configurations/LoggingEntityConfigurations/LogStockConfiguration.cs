using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.LoggingEntityConfigurations;

public class LogStockConfiguration : IEntityTypeConfiguration<LogStock>
{
    public void Configure(EntityTypeBuilder<LogStock> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("LogStocks").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.TransactionLogId).HasColumnName("TransactionLogId").IsRequired();
        builder.Property(p => p.StockId).HasColumnName("StockId").IsRequired();
        builder.Property(p => p.ProductId).HasColumnName("ProductId").IsRequired();
        builder.Property(p => p.FromLocaitonId).HasColumnName("FromLocaitonId").IsRequired();
        builder.Property(p => p.ToLocationId).HasColumnName("ToLocationId").IsRequired();
        builder.Property(p => p.TransactionTypeId).HasColumnName("TransactionTypeId").IsRequired();
        builder.Property(p => p.Quantity).HasColumnName("Quantity").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.TransactionLogId, p.StockId, p.ProductId, p.FromLocaitonId, p.ToLocationId, p.TransactionTypeId, p.Quantity, p.CreatedDate }, name: "IX_LogStocks_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasMany(p => p.LogStockAttributeValues);
        builder.HasMany(p => p.LogStockContainers);
        builder.HasMany(p => p.LogStockReserveReasons);
        builder.HasMany(p => p.LogStockUnsuitReasons);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
