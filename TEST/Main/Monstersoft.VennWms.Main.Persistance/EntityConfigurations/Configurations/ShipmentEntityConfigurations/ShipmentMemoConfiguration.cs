using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ShipmentEntityConfigurations;

public class ShipmentMemoConfiguration : IEntityTypeConfiguration<ShipmentMemo>
{
    public void Configure(EntityTypeBuilder<ShipmentMemo> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("ShipmentMemos").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.ShipmentId).HasColumnName("ShipmentId").IsRequired();
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
        builder.HasOne(p => p.Shipment);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
