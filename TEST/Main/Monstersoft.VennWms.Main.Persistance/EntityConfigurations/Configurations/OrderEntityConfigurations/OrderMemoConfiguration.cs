    using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.OrderEntityConfigurations;

public class OrderMemoConfiguration : IEntityTypeConfiguration<OrderMemo>
{
    public void Configure(EntityTypeBuilder<OrderMemo> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("OrderMemos").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.OrderId).HasColumnName("OrderId").IsRequired();
        builder.Property(p => p.Description).HasColumnName("Description").HasMaxLength(50).IsRequired();
        builder.Property(p => p.Text).HasColumnName("Text").HasMaxLength(500).IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.InputDate).HasColumnName("InputDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        builder.Property(p => p.EditDate).HasColumnName("EditDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.OrderId, p.Description, p.Text, p.EditDate, p.InputDate, p.CreatedDate }, name: "IX_OrderMemos_Areas");
        #endregion

        #region İlişki Tanımları
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
