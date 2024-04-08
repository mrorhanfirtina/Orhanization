using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.LoggingEntityConfigurations;

public class TransactionLogConfiguration : IEntityTypeConfiguration<TransactionLog>
{
    public void Configure(EntityTypeBuilder<TransactionLog> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("TransactionLogs").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.DepositorId).HasColumnName("DepositorId").IsRequired();
        builder.Property(p => p.DepositorCompanyId).HasColumnName("DepositorCompanyId").IsRequired();
        builder.Property(p => p.UserId).HasColumnName("UserId").IsRequired();
        builder.Property(p => p.OrderId).HasColumnName("OrderId");
        builder.Property(p => p.OrderItemId).HasColumnName("OrderItemId");
        builder.Property(p => p.ReturnId).HasColumnName("ReturnId");
        builder.Property(p => p.ReturnItemId).HasColumnName("ReturnItemId");
        builder.Property(p => p.ReceiptId).HasColumnName("ReceiptId");
        builder.Property(p => p.ReceiptItemId).HasColumnName("ReceiptItemId");
        builder.Property(p => p.WorkTaskId).HasColumnName("WorkTaskId");
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.DepositorId, p.DepositorCompanyId, p.UserId, p.OrderId, p.OrderItemId, p.ReturnId, p.ReturnItemId, p.ReceiptId, p.ReceiptItemId, p.WorkTaskId, p.CreatedDate }, name: "IX_TransactionLogs_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasMany(p => p.LogStocks);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
