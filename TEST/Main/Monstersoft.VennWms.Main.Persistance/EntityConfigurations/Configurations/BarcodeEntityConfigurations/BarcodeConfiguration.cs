using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.BarcodeEntityConfigurations;

public class BarcodeConfiguration : IEntityTypeConfiguration<Barcode>
{
    public void Configure(EntityTypeBuilder<Barcode> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("Barcodes").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
        builder.Property(p => p.Copy).HasColumnName("Copy").IsRequired();
        builder.Property(p => p.Query).HasColumnName("Query").HasColumnType("NVARCHAR(MAX)").IsRequired();
        builder.Property(p => p.Text).HasColumnName("Text").HasColumnType("NVARCHAR(MAX)").IsRequired();
        builder.Property(p => p.DepositorCompanyId).HasColumnName("DepositorCompanyId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.Code, p.DepositorCompanyId, p.CreatedDate }, name: "IX_Barcodes_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasMany(p => p.BarcodeAreas).WithOne().HasForeignKey(p => p.BarcodeId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.BarcodePrinters).WithOne().HasForeignKey(p => p.BarcodeId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(p => p.DepositorCompany).WithMany().HasForeignKey(p => p.DepositorCompanyId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
