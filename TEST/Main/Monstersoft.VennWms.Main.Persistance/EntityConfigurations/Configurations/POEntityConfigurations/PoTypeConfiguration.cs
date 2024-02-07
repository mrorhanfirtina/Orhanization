﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.POEntityConfigurations;

public class PoTypeConfiguration : IEntityTypeConfiguration<PoType>
{
    public void Configure(EntityTypeBuilder<PoType> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("PoTypes").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
        builder.Property(p => p.Description).HasColumnName("Description").HasMaxLength(60).IsRequired();
        builder.Property(p => p.Format).HasColumnName("Format").HasMaxLength(20).IsRequired();
        builder.Property(p => p.Counter).HasColumnName("Counter").IsRequired();
        builder.Property(p => p.DepositorId).HasColumnName("DepositorId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(indexExpression: p => p.Code, name: "UK_PoTypes_Code").IsUnique();
        builder.HasIndex(indexExpression: p => p.Description, name: "UK_PoTypes_Description").IsUnique();
        #endregion

        #region İlişki Tanımları
        builder.HasMany(p => p.PurchaseOrders);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
