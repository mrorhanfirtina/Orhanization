using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ReceiptEntityConfigurations;

public class ReceiptAttributeValueConfiguration : IEntityTypeConfiguration<ReceiptAttributeValue>
{
    public void Configure(EntityTypeBuilder<ReceiptAttributeValue> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("ReceiptAttributeValues", "receipt").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.ReceiptId).HasColumnName("ReceiptId").IsRequired();
        builder.Property(p => p.ReceiptAttributeId).HasColumnName("ReceiptAttributeId").IsRequired();
        builder.Property(p => p.Value).HasColumnName("Value").HasMaxLength(120).IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.ReceiptId, p.ReceiptAttributeId, p.Value, p.CreatedDate }, name: "IX_ReceiptAttributeValues_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.ReceiptAttribute).WithMany().HasForeignKey(p => p.ReceiptAttributeId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
