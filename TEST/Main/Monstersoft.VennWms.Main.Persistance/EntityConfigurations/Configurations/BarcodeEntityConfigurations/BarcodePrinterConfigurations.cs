using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.BarcodeEntityConfigurations;

public class BarcodePrinterConfigurations : IEntityTypeConfiguration<BarcodePrinter>
{
    public void Configure(EntityTypeBuilder<BarcodePrinter> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("BarcodePrinters").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.BarcodeId).HasColumnName("BarcodeId").IsRequired();
        builder.Property(p => p.PrinterId).HasColumnName("PrinterId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.BarcodeId, p.PrinterId, p.CreatedDate }, name: "IX_BarcodePrinters_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.Printer).WithMany().HasForeignKey(p => p.PrinterId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
