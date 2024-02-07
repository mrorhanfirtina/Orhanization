using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ReceiptEntityConfigurations;

public class ReceiptConfiguration : IEntityTypeConfiguration<Receipt>
{
    public void Configure(EntityTypeBuilder<Receipt> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("Receipts").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
        builder.Property(p => p.DepositorId).HasColumnName("DepositorId").IsRequired();
        builder.Property(p => p.PurchaseOrderId).HasColumnName("PurchaseOrderId").IsRequired();
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
        builder.HasIndex(indexExpression: p => p.Code, name: "UK_Receipts_Code").IsUnique();
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.PurchaseOrder);
        builder.HasOne(p => p.ReceiptType);
        builder.HasMany(p => p.TransactionLogs);
        builder.HasMany(p => p.ReceiptAttributeValues);
        builder.HasMany(p => p.ReceiptItems);
        builder.HasMany(p => p.ReceiptItmStockAttrValues);
        builder.HasMany(p => p.ReceiptMemos);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
