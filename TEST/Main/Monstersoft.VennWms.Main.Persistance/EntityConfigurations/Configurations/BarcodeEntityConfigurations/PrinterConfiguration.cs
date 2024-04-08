using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.BarcodeEntityConfigurations;

public class PrinterConfiguration : IEntityTypeConfiguration<Printer>
{
    public void Configure(EntityTypeBuilder<Printer> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("Printers").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
        builder.Property(p => p.PrinterAddress).HasColumnName("PrinterAddress").HasMaxLength(600).IsRequired();
        builder.Property(p => p.DepositorCompanyId).HasColumnName("DepositorCompanyId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.Code, p.PrinterAddress, p.DepositorCompanyId, p.CreatedDate }, name: "IX_Printers_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.DepositorCompany).WithMany().HasForeignKey(p => p.DepositorCompanyId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
