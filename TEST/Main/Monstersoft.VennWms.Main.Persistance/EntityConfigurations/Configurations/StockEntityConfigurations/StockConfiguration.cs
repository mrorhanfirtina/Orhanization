﻿using Microsoft.EntityFrameworkCore;
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
        builder.Property(p => p.DepositorCompanyId).HasColumnName("DepositorCompanyId").IsRequired();
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
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.StockContainerId, p.ProductId, p.DepositorId, p.DepositorCompanyId, p.LocationId, p.UnitId, p.ReceiptId, p.ReturnId, p.Quantity, p.FreeQuantity, p.CreatedDate }, name: "IX_Stocks_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.StockContainer).WithMany().HasForeignKey(p => p.StockContainerId).OnDelete(DeleteBehavior.NoAction);
        builder.HasMany(p => p.StockAttributeValues).WithOne().HasForeignKey(p => p.StockId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.StockMemos).WithOne().HasForeignKey(p => p.StockId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.StockReserveReasons).WithOne().HasForeignKey(p => p.StockId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.StockUnsuitReasons).WithOne().HasForeignKey(p => p.StockId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(p => p.Product).WithMany().HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.Depositor).WithMany().HasForeignKey(p => p.DepositorId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.DepositorCompany).WithMany().HasForeignKey(p => p.DepositorCompanyId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.Location).WithMany().HasForeignKey(p => p.LocationId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.Unit).WithMany().HasForeignKey(p => p.UnitId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.Receipt).WithMany().HasForeignKey(p => p.ReceiptId).OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(p => p.Return).WithMany().HasForeignKey(p => p.ReturnId).OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
