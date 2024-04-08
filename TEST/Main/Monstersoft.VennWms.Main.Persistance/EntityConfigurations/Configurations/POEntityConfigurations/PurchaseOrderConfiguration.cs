using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.POEntityConfigurations;

public class PurchaseOrderConfiguration : IEntityTypeConfiguration<PurchaseOrder>
{
    public void Configure(EntityTypeBuilder<PurchaseOrder> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("PurchaseOrders").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
        builder.Property(p => p.DepositorId).HasColumnName("DepositorId").IsRequired();
        builder.Property(p => p.DepositorCompanyId).HasColumnName("DepositorCompanyId").IsRequired();
        builder.Property(p => p.SupplierId).HasColumnName("SupplierId").IsRequired();
        builder.Property(p => p.PoTypeId).HasColumnName("PoTypeId").IsRequired();
        builder.Property(p => p.StatusId).HasColumnName("StatusId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.Code, p.DepositorId, p.DepositorCompanyId, p.SupplierId, p.PoTypeId, p.StatusId, p.CreatedDate }, name: "IX_PurchaseOrders_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.Supplier).WithMany().HasForeignKey(p => p.SupplierId).OnDelete(DeleteBehavior.Restrict);
        builder.HasMany(p => p.PoAttributeValues).WithOne().HasForeignKey(p => p.PurchaseOrderId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.PoMemos).WithOne().HasForeignKey(p => p.PurchaseOrderId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.Receipts).WithOne().HasForeignKey(p => p.PurchaseOrderId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(p => p.Depositor).WithMany().HasForeignKey(p => p.DepositorId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.DepositorCompany).WithMany().HasForeignKey(p => p.DepositorCompanyId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.Status).WithMany().HasForeignKey(p => p.StatusId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
