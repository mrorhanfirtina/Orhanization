﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.LocationEntityConfigurations;

public class StorageSystemConfiguration : IEntityTypeConfiguration<StorageSystem>
{
    public void Configure(EntityTypeBuilder<StorageSystem> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("StorageSystems").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
        builder.Property(p => p.Description).HasColumnName("Description").HasMaxLength(30).IsRequired();
        builder.Property(p => p.SiteId).HasColumnName("SiteId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(indexExpression: p => p.Code, name: "UK_StorageSystems_Code").IsUnique();
        builder.HasIndex(indexExpression: p => p.Description, name: "UK_StorageSystems_Description").IsUnique();
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.Site);
        builder.HasMany(p => p.Locations);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
