using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ShipmentEntityConfigurations;

public class OrderShipmentConfiguration : IEntityTypeConfiguration<OrderShipment>
{
    public void Configure(EntityTypeBuilder<OrderShipment> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("OrderShipments").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
        builder.Property(p => p.OrderId).HasColumnName("OrderId").IsRequired();
        builder.Property(p => p.ShipmentId).HasColumnName("ShipmentId").IsRequired();
        builder.Property(p => p.ProgressStatusId).HasColumnName("ProgressStatusId").IsRequired();
        builder.Property(p => p.LastMoveDate).HasColumnName("LastMoveDate");
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(indexExpression: p => p.Code, name: "UK_OrderShipments_Code").IsUnique();
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.Order);
        builder.HasOne(p => p.ProgressStatus);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
