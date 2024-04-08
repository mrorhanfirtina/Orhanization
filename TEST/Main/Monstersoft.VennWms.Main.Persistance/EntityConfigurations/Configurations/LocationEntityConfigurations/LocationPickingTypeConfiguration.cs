using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.LocationEntityConfigurations;

public class LocationPickingTypeConfiguration : IEntityTypeConfiguration<LocationPickingType>
{
    public void Configure(EntityTypeBuilder<LocationPickingType> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("LocationPickingTypes").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.LocationId).HasColumnName("LocationId").IsRequired();
        builder.Property(p => p.PickingTypeId).HasColumnName("PickingTypeId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.LocationId, p.PickingTypeId, p.CreatedDate }, name: "IX_LocationPickingTypes_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.PickingType).WithMany().HasForeignKey(p => p.PickingTypeId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
