using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ShipmentEntityConfigurations;

public class OrderShipItemConfiguration : IEntityTypeConfiguration<OrderShipItem>
{
    public void Configure(EntityTypeBuilder<OrderShipItem> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("OrderShipItems").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.OrderItemId).HasColumnName("OrderItemId").IsRequired();
        builder.Property(p => p.OrderShipmentId).HasColumnName("OrderShipmentId").IsRequired();
        builder.Property(p => p.ProgressStatusId).HasColumnName("ProgressStatusId").IsRequired();
        builder.Property(p => p.Quantity).HasColumnName("Quantity").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.OrderItemId, p.OrderShipmentId, p.ProgressStatusId, p.Quantity, p.CreatedDate }, name: "IX_OrderShipItems_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasMany(p => p.OrderShipItemTasks).WithOne().HasForeignKey(p => p.OrderShipItemId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(p => p.ProgressStatus).WithMany().HasForeignKey(p => p.ProgressStatusId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
