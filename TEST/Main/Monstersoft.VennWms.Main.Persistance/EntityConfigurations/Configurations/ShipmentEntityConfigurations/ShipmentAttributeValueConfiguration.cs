using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ShipmentEntityConfigurations;

public class ShipmentAttributeValueConfiguration : IEntityTypeConfiguration<ShipmentAttributeValue>
{
    public void Configure(EntityTypeBuilder<ShipmentAttributeValue> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("ShipmentAttributeValues", "shipment").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.ShipmentId).HasColumnName("ShipmentId").IsRequired();
        builder.Property(p => p.ShipmentAttributeId).HasColumnName("ShipmentAttributeId").IsRequired();
        builder.Property(p => p.Value).HasColumnName("Value").HasMaxLength(120).IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.ShipmentId, p.ShipmentAttributeId, p.Value, p.CreatedDate }, name: "IX_ShipmentAttributeValues_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.ShipmentAttribute).WithMany().HasForeignKey(p => p.ShipmentAttributeId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
