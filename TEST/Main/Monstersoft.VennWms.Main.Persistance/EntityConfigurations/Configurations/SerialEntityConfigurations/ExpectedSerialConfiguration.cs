using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.SerialEntityConfigurations;

public class ExpectedSerialConfiguration : IEntityTypeConfiguration<ExpectedSerial>
{
    public void Configure(EntityTypeBuilder<ExpectedSerial> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("ExpectedSerials", "serial").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.ItemUnitId).HasColumnName("ItemUnitId").IsRequired();
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
        builder.HasIndex(p => new { p.ItemUnitId, p.DepositorId, p.DepositorCompanyId, p.ReceiptId, p.ReceiptItemId, p.SerialNo, p.SSCC, p.CreatedDate }, name: "IX_ExpectedSerials_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.ItemUnit).WithMany().HasForeignKey(p => p.ItemUnitId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.Depositor).WithMany().HasForeignKey(p => p.DepositorId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.DepositorCompany).WithMany().HasForeignKey(p => p.DepositorCompanyId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.Receipt).WithMany().HasForeignKey(p => p.ReceiptId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.ReceiptItem).WithMany().HasForeignKey(p => p.ReceiptItemId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion

    }
}
