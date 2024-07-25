using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.SerialEntityConfigurations;

public class SerialLogConfiguration : IEntityTypeConfiguration<SerialLog>
{
    public void Configure(EntityTypeBuilder<SerialLog> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("SerialLogs", "serial").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.TransactionLogId).HasColumnName("TransactionLogId").IsRequired();
        builder.Property(p => p.TransactionTypeId).HasColumnName("TransactionTypeId").IsRequired();
        builder.Property(p => p.DepositorId).HasColumnName("DepositorId").IsRequired();
        builder.Property(p => p.DepositorCompanyId).HasColumnName("DepositorCompanyId").IsRequired();
        builder.Property(p => p.ReceiptId).HasColumnName("ReceiptId").IsRequired();
        builder.Property(p => p.SerialNo).HasColumnName("SerialNo").HasMaxLength(30).IsRequired();
        builder.Property(p => p.SSCC).HasColumnName("SSCC").HasMaxLength(30).IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.TransactionLogId, p.DepositorId, p.DepositorCompanyId, p.ReceiptId, p.SerialNo, p.SSCC, p.CreatedDate }, name: "IX_SerialLogs_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.Depositor).WithMany().HasForeignKey(p => p.DepositorId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.DepositorCompany).WithMany().HasForeignKey(p => p.DepositorCompanyId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.Receipt).WithMany().HasForeignKey(p => p.ReceiptId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.TransactionLog).WithMany().HasForeignKey(p => p.TransactionLogId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.TransactionType).WithMany().HasForeignKey(p => p.TransactionTypeId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
