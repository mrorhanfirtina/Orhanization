using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ProductEntityConfigurations;

public class ItemUnitConversionConfiguration : IEntityTypeConfiguration<ItemUnitConversion>
{
    public void Configure(EntityTypeBuilder<ItemUnitConversion> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("ItemUnitConversions").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.ReferenceItemUnitId).HasColumnName("ReferenceItemUnitId").IsRequired();
        builder.Property(p => p.ConvertedItemUnitId).HasColumnName("ConvertedItemUnitId").IsRequired();
        builder.Property(p => p.ConversionQuantity).HasColumnName("ConversionQuantity").IsRequired().HasColumnType("decimal(18,6)");
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.ReferenceItemUnitId, p.ConvertedItemUnitId, p.ConversionQuantity, p.CreatedDate }, name: "IX_ItemUnitConversions_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.ReferenceItemUnit).WithMany().HasForeignKey(p => p.ReferenceItemUnitId).OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(p => p.ConvertedItemUnit).WithMany().HasForeignKey(p => p.ConvertedItemUnitId).OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
