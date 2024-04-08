using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.OrderEntityConfigurations;

public class OrderAttributeValueConfiguration : IEntityTypeConfiguration<OrderAttributeValue>
{
    public void Configure(EntityTypeBuilder<OrderAttributeValue> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("OrderAttributeValues").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.OrderId).HasColumnName("OrderId").IsRequired();
        builder.Property(p => p.OrderAttributeId).HasColumnName("OrderAttributeId").IsRequired();
        builder.Property(p => p.Value).HasColumnName("Value").HasMaxLength(120).IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.OrderId, p.OrderAttributeId, p.Value, p.CreatedDate }, name: "IX_OrderAttributeValues_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.OrderAttribute).WithMany().HasForeignKey(p => p.OrderAttributeId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
