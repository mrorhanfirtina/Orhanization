using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.LocationEntityConfigurations;

public class BuildingConfiguration : IEntityTypeConfiguration<Building>
{
    public void Configure(EntityTypeBuilder<Building> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("Buildings").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
        builder.Property(p => p.Description).HasColumnName("Description").HasMaxLength(120).IsRequired();
        builder.Property(p => p.Province).HasColumnName("Province").HasMaxLength(60).IsRequired();
        builder.Property(p => p.City).HasColumnName("City").HasMaxLength(60).IsRequired();
        builder.Property(p => p.Country).HasColumnName("Country").HasMaxLength(60).IsRequired();
        builder.Property(p => p.Address).HasColumnName("Address").HasMaxLength(250).IsRequired();
        builder.Property(p => p.ZipCode).HasColumnName("ZipCode").HasMaxLength(10).IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");        
        #endregion

        #region Indexler
        builder.HasIndex(indexExpression: p => p.Code, name: "UK_Buildings_Code").IsUnique();
        builder.HasIndex(indexExpression: p => p.Description, name: "UK_Buildings_Description").IsUnique();
        #endregion

        #region İlişki Tanımları
        builder.HasMany(p => p.Sites);
        builder.HasMany(p => p.Branches);
        builder.HasMany(p => p.Customers);
        builder.HasMany(p => p.Depositors);
        builder.HasMany(p => p.Disturbitors);
        builder.HasMany(p => p.Receivers);
        builder.HasMany(p => p.Suppliers);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
