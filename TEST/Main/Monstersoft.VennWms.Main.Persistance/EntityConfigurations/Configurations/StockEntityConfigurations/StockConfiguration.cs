using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.StockEntityConfigurations;

public class StockConfiguration : IEntityTypeConfiguration<Stock>
{
    public void Configure(EntityTypeBuilder<Stock> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("Stocks", "stock").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.StockContainerId).HasColumnName("StockContainerId").IsRequired();
        builder.Property(p => p.ProductId).HasColumnName("ProductId").IsRequired();
        builder.Property(p => p.DepositorId).HasColumnName("DepositorId").IsRequired();
        builder.Property(p => p.DepositorCompanyId).HasColumnName("DepositorCompanyId").IsRequired();
        builder.Property(p => p.LocationId).HasColumnName("LocationId").IsRequired();
        builder.Property(p => p.CuItemUnitId).HasColumnName("CuItemUnitId").IsRequired();
        builder.Property(p => p.CuQuantity).HasColumnName("CuQuantity").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.CuQuantityFree).HasColumnName("CuQuantityFree").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.StockContainerId, p.ProductId, p.DepositorId, p.DepositorCompanyId, p.LocationId, p.CuItemUnitId, p.CuQuantity, p.CuQuantityFree, p.CreatedDate }, name: "IX_Stocks_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.StockContainer).WithMany(p => p.Stocks).HasForeignKey(p => p.StockContainerId).OnDelete(DeleteBehavior.NoAction);
        builder.HasMany(p => p.StockAttributeValues).WithOne(p => p.Stock).HasForeignKey(p => p.StockId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.StockMemos).WithOne(p => p.Stock).HasForeignKey(p => p.StockId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.StockReserveReasons).WithOne(p => p.Stock).HasForeignKey(p => p.StockId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.StockUnsuitReasons).WithOne(p => p.Stock).HasForeignKey(p => p.StockId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(p => p.Product).WithMany().HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.Depositor).WithMany().HasForeignKey(p => p.DepositorId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.DepositorCompany).WithMany().HasForeignKey(p => p.DepositorCompanyId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.Location).WithMany().HasForeignKey(p => p.LocationId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.CuItemUnit).WithMany().HasForeignKey(p => p.CuItemUnitId).OnDelete(DeleteBehavior.Restrict);
        builder.HasMany(p => p.StockInbounds).WithOne(p => p.Stock).HasForeignKey(p => p.StockId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.StockPackTypes).WithOne(p => p.Stock).HasForeignKey(p => p.StockId).OnDelete(DeleteBehavior.Cascade);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
