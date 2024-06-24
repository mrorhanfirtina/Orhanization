using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.LocationEntityConfigurations;

public class LocationProductAbcCategoryConfiguration : IEntityTypeConfiguration<LocationProductAbcCategory>
{
    public void Configure(EntityTypeBuilder<LocationProductAbcCategory> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("LocationProductAbcCategories", "location").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.LocationId).HasColumnName("LocationId").IsRequired();
        builder.Property(p => p.AbcCategoryId).HasColumnName("AbcCategoryId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.LocationId, p.AbcCategoryId, p.CreatedDate }, name: "IX_LocationProductAbcCategories_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.AbcCategory).WithMany().HasForeignKey(p => p.AbcCategoryId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
