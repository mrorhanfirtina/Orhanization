using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.LocationEntityConfigurations;

public class BuildingConfiguration : IEntityTypeConfiguration<Building>
{
    public void Configure(EntityTypeBuilder<Building> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("Buildings", "location").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
        builder.Property(p => p.SiteId).HasColumnName("SiteId").IsRequired();
        builder.Property(p => p.Description).HasColumnName("Description").HasMaxLength(120).IsRequired();
        builder.Property(p => p.Province).HasColumnName("Province").HasMaxLength(60).IsRequired();
        builder.Property(p => p.City).HasColumnName("City").HasMaxLength(60).IsRequired();
        builder.Property(p => p.Country).HasColumnName("Country").HasMaxLength(60).IsRequired();
        builder.Property(p => p.AddressText).HasColumnName("AddressText").HasMaxLength(250).IsRequired();
        builder.Property(p => p.ZipCode).HasColumnName("ZipCode").HasMaxLength(15).IsRequired();
        builder.Property(p => p.DepositorCompanyId).HasColumnName("DepositorCompanyId").IsRequired();
        builder.Property(p => p.Latitude).HasColumnName("Latitude").HasColumnType("DECIMAL(11,7)");
        builder.Property(p => p.Longitude).HasColumnName("Longitude").HasColumnType("DECIMAL(11,7)");
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.Code, p.SiteId, p.Description, p.Province, p.City, p.Country, p.AddressText, p.ZipCode, p.DepositorCompanyId, p.Longitude, p.Latitude, p.CreatedDate }, name: "IX_Buildings_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.DepositorCompany).WithMany().HasForeignKey(p => p.DepositorCompanyId).OnDelete(DeleteBehavior.Restrict);
        builder.HasMany(p => p.StorageSystems).WithOne(p => p.Building).HasForeignKey(p => p.BuildingId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(p => p.Site).WithMany(p => p.Buildings).HasForeignKey(p => p.SiteId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.BuildingDimension).WithOne(p => p.Building).HasForeignKey<BuildingDimension>(p => p.BuildingId).OnDelete(DeleteBehavior.Cascade);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
