using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.SerialEntityConfigurations;

public class SerialConfiguration : IEntityTypeConfiguration<Serial>
{
    public void Configure(EntityTypeBuilder<Serial> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("Serials", "serial").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.StockPackTypeId).HasColumnName("StockPackTypeId").IsRequired();
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
        builder.HasIndex(p => new { p.StockPackTypeId, p.DepositorId, p.DepositorCompanyId, p.ReceiptId, p.ReceiptItemId, p.SerialNo, p.SSCC, p.CreatedDate }, name: "IX_Serials_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.StockPackType).WithMany().HasForeignKey(p => p.StockPackTypeId).OnDelete(DeleteBehavior.Restrict);
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
