using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.LoggingEntityConfigurations;

public class LogStockConfiguration : IEntityTypeConfiguration<LogStock>
{
    public void Configure(EntityTypeBuilder<LogStock> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("LogStocks", "logging").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.TransactionLogId).HasColumnName("TransactionLogId").IsRequired();
        builder.Property(p => p.StockId).HasColumnName("StockId");
        builder.Property(p => p.ProductId).HasColumnName("ProductId").IsRequired();
        builder.Property(p => p.FromLocationId).HasColumnName("FromLocationId").IsRequired();
        builder.Property(p => p.ToLocationId).HasColumnName("ToLocationId").IsRequired();
        builder.Property(p => p.TransactionTypeId).HasColumnName("TransactionTypeId").IsRequired();
        builder.Property(p => p.Quantity).HasColumnName("Quantity").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.TransactionLogId, p.StockId, p.ProductId, p.FromLocationId, p.ToLocationId, p.TransactionTypeId, p.Quantity, p.CreatedDate }, name: "IX_LogStocks_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasMany(p => p.LogStockAttributeValues).WithOne(p => p.LogStock).HasForeignKey(p => p.LogStockId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.LogStockContainers).WithOne(p => p.LogStock).HasForeignKey(p => p.LogStockId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.LogStockReserveReasons).WithOne(p => p.LogStock).HasForeignKey(p => p.LogStockId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.LogStockUnsuitReasons).WithOne(p => p.LogStock).HasForeignKey(p => p.LogStockId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(p => p.Product).WithMany().HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.FromLocation).WithMany().HasForeignKey(p => p.FromLocationId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.ToLocation).WithMany().HasForeignKey(p => p.ToLocationId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
