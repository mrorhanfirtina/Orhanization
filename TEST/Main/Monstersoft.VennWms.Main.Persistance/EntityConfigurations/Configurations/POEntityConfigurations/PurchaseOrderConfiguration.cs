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
        builder.Property(p => p.SupplierId).HasColumnName("SupplierId").IsRequired();
        builder.Property(p => p.PoTypeId).HasColumnName("PoTypeId").IsRequired();
        builder.Property(p => p.StatusId).HasColumnName("StatusId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(indexExpression: p => p.Code, name: "UK_PurchaseOrders_Code").IsUnique();
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.Supplier);
        builder.HasOne(p => p.PoType);
        builder.HasMany(p => p.PoAttributeValues);
        builder.HasMany(p => p.PoMemos);
        builder.HasMany(p => p.Receipts);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
