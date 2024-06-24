using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.POEntityConfigurations;

public class PoAttributeValueConfiguration : IEntityTypeConfiguration<PoAttributeValue>
{
    public void Configure(EntityTypeBuilder<PoAttributeValue> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("PoAttributeValues", "po").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.PurchaseOrderId).HasColumnName("PurchaseOrderId").IsRequired();
        builder.Property(p => p.PoAttributeId).HasColumnName("PoAttributeId").IsRequired();
        builder.Property(p => p.Value).HasColumnName("Value").HasMaxLength(120).IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.PurchaseOrderId, p.PoAttributeId, p.Value, p.CreatedDate }, name: "IX_PoAttributeValues_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.PoAttribute).WithMany().HasForeignKey(p => p.PoAttributeId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
