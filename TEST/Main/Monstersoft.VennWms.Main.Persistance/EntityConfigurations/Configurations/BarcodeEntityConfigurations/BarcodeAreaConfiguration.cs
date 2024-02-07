using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.BarcodeEntityConfigurations;

public class BarcodeAreaConfiguration : IEntityTypeConfiguration<BarcodeArea>
    {
    public void Configure(EntityTypeBuilder<BarcodeArea> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("BarcodeAreas").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.BarcodeId).HasColumnName("BarcodeId").IsRequired();
        builder.Property(p => p.QueryField).HasColumnName("QueryField").HasMaxLength(60).IsRequired();
        builder.Property(p => p.TextField).HasColumnName("TextField").HasMaxLength(60).IsRequired();

        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.Barcode);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
