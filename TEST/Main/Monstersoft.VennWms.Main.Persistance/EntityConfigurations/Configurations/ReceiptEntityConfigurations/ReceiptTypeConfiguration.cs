using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ReceiptEntityConfigurations;

public class ReceiptTypeConfiguration : IEntityTypeConfiguration<ReceiptType>
{
    public void Configure(EntityTypeBuilder<ReceiptType> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("ReceiptTypes").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
        builder.Property(p => p.Description).HasColumnName("Description").HasMaxLength(60).IsRequired();
        builder.Property(p => p.Format).HasColumnName("Format").HasMaxLength(20).IsRequired();
        builder.Property(p => p.Counter).HasColumnName("Counter").IsRequired();
        builder.Property(p => p.DepositorId).HasColumnName("DepositorId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(indexExpression: p => p.Code, name: "UK_ReceiptTypes_Code").IsUnique();
        builder.HasIndex(indexExpression: p => p.Description, name: "UK_ReceiptTypes_Description").IsUnique();
        #endregion

        #region İlişki Tanımları
        builder.HasMany(p => p.Receipts);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
