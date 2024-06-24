using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ShipmentEntityConfigurations;

public class OrderShipmentConfiguration : IEntityTypeConfiguration<OrderShipment>
{
    public void Configure(EntityTypeBuilder<OrderShipment> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("OrderShipments", "shipment").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
        builder.Property(p => p.OrderId).HasColumnName("OrderId").IsRequired();
        builder.Property(p => p.ShipmentId).HasColumnName("ShipmentId").IsRequired();
        builder.Property(p => p.DepositorCompanyId).HasColumnName("DepositorCompanyId").IsRequired();
        builder.Property(p => p.ProgressStatusId).HasColumnName("ProgressStatusId").IsRequired();
        builder.Property(p => p.LastMoveDate).HasColumnName("LastMoveDate");
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.Code, p.OrderId, p.ShipmentId, p.ProgressStatusId, p.LastMoveDate, p.CreatedDate }, name: "IX_OrderShipments_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasMany(p => p.OrderShipItems).WithOne(p => p.OrderShipment).HasForeignKey(p => p.OrderShipmentId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(p => p.Shipment).WithMany(p => p.OrderShipments).HasForeignKey(p => p.ShipmentId).OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(p => p.DepositorCompany).WithMany().HasForeignKey(p => p.DepositorCompanyId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.ProgressStatus).WithMany().HasForeignKey(p => p.ProgressStatusId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
