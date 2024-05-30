using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.StockEntityConfigurations;

public class StockInboundConfiguration : IEntityTypeConfiguration<StockInbound>
{
    public void Configure(EntityTypeBuilder<StockInbound> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("StockInbounds", "stock").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.StockId).HasColumnName("StockId").IsRequired();
        builder.Property(p => p.ReceiptId).HasColumnName("ReceiptId");
        builder.Property(p => p.ReturnId).HasColumnName("ReturnId");
        builder.Property(p => p.CuItemUnitId).HasColumnName("CuItemUnitId").IsRequired();
        builder.Property(p => p.CuQuantity).HasColumnName("CuQuantity").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.CuQuantityFree).HasColumnName("CuQuantityFree").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.StockId, p.ReceiptId, p.ReturnId, p.CuItemUnitId, p.CuQuantity, p.CuQuantityFree, p.CreatedDate }, name: "IX_StockInbounds_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.CuItemUnit).WithMany().HasForeignKey(p => p.CuItemUnitId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.Receipt).WithMany().HasForeignKey(p => p.ReceiptId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.Return).WithMany().HasForeignKey(p => p.ReturnId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
