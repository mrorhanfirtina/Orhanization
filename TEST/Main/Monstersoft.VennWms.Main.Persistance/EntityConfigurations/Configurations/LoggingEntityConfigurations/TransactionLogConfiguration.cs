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
        builder.Property(p => p.UserId).HasColumnName("UserId").IsRequired();
        builder.Property(p => p.OrderId).HasColumnName("OrderId");
        builder.Property(p => p.ReturnId).HasColumnName("ReturnId");
        builder.Property(p => p.ReceiptId).HasColumnName("ReceiptId");
        builder.Property(p => p.WorkTaskId).HasColumnName("WorkTaskId");
        builder.Property(p => p.DepositorId).HasColumnName("DepositorId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.Order);
        builder.HasOne(p => p.Return);
        builder.HasOne(p => p.Receipt);
        builder.HasOne(p => p.WorkTask);
        builder.HasMany(p => p.LogStocks);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
