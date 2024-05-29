using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.LocationEntityConfigurations;

public class LocationUnitConstraintConfiguration : IEntityTypeConfiguration<LocationUnitConstraint>
{
    public void Configure(EntityTypeBuilder<LocationUnitConstraint> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("LocationUnitConstraints", "location").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.LocationId).HasColumnName("LocationId").IsRequired();
        builder.Property(p => p.UnitId).HasColumnName("UnitId").IsRequired();
        builder.Property(p => p.Capacity).HasColumnName("Capacity").HasColumnType("DECIMAL(18,6)").IsRequired();
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.LocationId, p.UnitId, p.CreatedDate }, name: "IX_LocationUnitConstraints_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.Unit).WithMany().HasForeignKey(p => p.UnitId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
