﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ReturnEntityConfigurations;

public class ReturnItemMemoConfiguration : IEntityTypeConfiguration<ReturnItemMemo>
{
    public void Configure(EntityTypeBuilder<ReturnItemMemo> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("ReturnItemMemos").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.ReturnItemId).HasColumnName("ReturnItemId").IsRequired();
        builder.Property(p => p.Description).HasColumnName("Description").HasMaxLength(50).IsRequired();
        builder.Property(p => p.Text).HasColumnName("Text").HasMaxLength(500).IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.InputDate).HasColumnName("InputDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        builder.Property(p => p.EditDate).HasColumnName("EditDate");
        #endregion

        #region Indexler

        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.ReturnItem);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}