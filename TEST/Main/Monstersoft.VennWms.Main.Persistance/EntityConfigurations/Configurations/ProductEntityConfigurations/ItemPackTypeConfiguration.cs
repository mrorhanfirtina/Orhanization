using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ProductEntityConfigurations;

public class ItemPackTypeConfiguration : IEntityTypeConfiguration<ItemPackType>
{
    public void Configure(EntityTypeBuilder<ItemPackType> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("ItemPackTypes", "product").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.ItemUnitId).HasColumnName("ItemUnitId").IsRequired();
        builder.Property(p => p.Length).HasColumnName("Length").HasColumnType("decimal(18,6)");
        builder.Property(p => p.Width).HasColumnName("Width").HasColumnType("decimal(18,6)");
        builder.Property(p => p.Height).HasColumnName("Height").HasColumnType("decimal(18,6)");
        builder.Property(p => p.LenghtUnitId).HasColumnName("LenghtUnitId");
        builder.Property(p => p.Volume).HasColumnName("Volume").HasColumnType("decimal(18,6)");
        builder.Property(p => p.VolumeUnitId).HasColumnName("VolumeUnitId");
        builder.Property(p => p.DeadWeight).HasColumnName("DeadWeight").HasColumnType("decimal(18,6)");
        builder.Property(p => p.NetWeight).HasColumnName("NetWeight").HasColumnType("decimal(18,6)");
        builder.Property(p => p.WeightUnitId).HasColumnName("WeightUnitId");
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.ItemUnitId, p.Length, p.Width, p.Height, p.LenghtUnitId, p.Volume, p.VolumeUnitId, p.DeadWeight, p.NetWeight, p.WeightUnitId, p.CreatedDate }, name: "IX_ItemPackTypes_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.LenghtUnit).WithMany().HasForeignKey(p => p.LenghtUnitId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.VolumeUnit).WithMany().HasForeignKey(p => p.VolumeUnitId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.WeightUnit).WithMany().HasForeignKey(p => p.WeightUnitId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
