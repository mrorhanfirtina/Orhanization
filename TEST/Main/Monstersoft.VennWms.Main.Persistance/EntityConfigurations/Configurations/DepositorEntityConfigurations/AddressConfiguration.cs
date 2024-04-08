using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.DepositorEntityConfigurations;

public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("Addresses").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Description).HasColumnName("Description").HasMaxLength(120).IsRequired();
        builder.Property(p => p.Province).HasColumnName("Province").HasMaxLength(60).IsRequired();
        builder.Property(p => p.City).HasColumnName("City").HasMaxLength(60).IsRequired();
        builder.Property(p => p.Country).HasColumnName("Country").HasMaxLength(60).IsRequired();
        builder.Property(p => p.AddressText).HasColumnName("AddressText").HasMaxLength(250).IsRequired();
        builder.Property(p => p.ZipCode).HasColumnName("ZipCode").HasMaxLength(10).IsRequired();
        builder.Property(p => p.Latitude).HasColumnName("Latitude").HasColumnType("DECIMAL(11,7)");
        builder.Property(p => p.Longitude).HasColumnName("Longitude").HasColumnType("DECIMAL(11,7)");
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.Description, p.Province, p.City, p.Country, p.AddressText, p.ZipCode, p.Latitude, p.Longitude , p.CreatedDate }, name: "IX_Adresses_Areas");
        #endregion

        #region İlişki Tanımları

        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
