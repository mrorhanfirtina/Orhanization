using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ReceiptEntityConfigurations;

public class ReceiptItemMemoConfiguration : IEntityTypeConfiguration<ReceiptItemMemo>
{
    public void Configure(EntityTypeBuilder<ReceiptItemMemo> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("ReceiptItemMemos").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.ReceiptItemId).HasColumnName("ReceiptItemId").IsRequired();
        builder.Property(p => p.Description).HasColumnName("Description").HasMaxLength(50).IsRequired();
        builder.Property(p => p.Text).HasColumnName("Text").HasMaxLength(500).IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.InputDate).HasColumnName("InputDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        builder.Property(p => p.EditDate).HasColumnName("EditDate");
        #endregion

        #region Indexler

        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.ReceiptItem);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
