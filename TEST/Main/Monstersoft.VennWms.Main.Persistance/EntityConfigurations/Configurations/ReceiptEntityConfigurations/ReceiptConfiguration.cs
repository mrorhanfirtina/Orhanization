using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ReceiptEntityConfigurations;

public class ReceiptConfiguration : IEntityTypeConfiguration<Receipt>
{
    public void Configure(EntityTypeBuilder<Receipt> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("Receipts", "receipt").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
        builder.Property(p => p.DepositorId).HasColumnName("DepositorId").IsRequired();
        builder.Property(p => p.DepositorCompanyId).HasColumnName("DepositorCompanyId").IsRequired();
        builder.Property(p => p.PurchaseOrderId).HasColumnName("PurchaseOrderId");
        builder.Property(p => p.ReceiptTypeId).HasColumnName("ReceiptTypeId").IsRequired();
        builder.Property(p => p.StatusId).HasColumnName("StatusId").IsRequired();
        builder.Property(p => p.InputDate).HasColumnName("InputDate").IsRequired();
        builder.Property(p => p.ExpectedDate).HasColumnName("ExpectedDate");
        builder.Property(p => p.ReceiveDate).HasColumnName("ReceiveDate");
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.Code, p.DepositorId, p.DepositorCompanyId, p.PurchaseOrderId, p.ReceiptTypeId, p.StatusId, p.InputDate, p.ExpectedDate, p.ReceiveDate, p.CreatedDate }, name: "IX_Receipts_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasMany(p => p.ReceiptAttributeValues).WithOne().HasForeignKey(p => p.ReceiptId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.ReceiptItems).WithOne().HasForeignKey(p => p.ReceiptId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.ReceiptMemos).WithOne().HasForeignKey(p => p.ReceiptId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(p => p.Status).WithMany().HasForeignKey(p => p.StatusId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.Depositor).WithMany().HasForeignKey(p => p.DepositorId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.DepositorCompany).WithMany().HasForeignKey(p => p.DepositorCompanyId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
