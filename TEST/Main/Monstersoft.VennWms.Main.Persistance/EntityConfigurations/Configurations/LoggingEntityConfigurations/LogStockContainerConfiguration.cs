﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.LoggingEntityConfigurations;

public class LogStockContainerConfiguration : IEntityTypeConfiguration<LogStockContainer>
{
    public void Configure(EntityTypeBuilder<LogStockContainer> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("LogStockContainers").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.LogStockId).HasColumnName("LogStockId").IsRequired();
        builder.Property(p => p.FromContainerId).HasColumnName("FromContainerId").IsRequired();
        builder.Property(p => p.ToContainerId).HasColumnName("ToContainerId").IsRequired();
        builder.Property(p => p.FromContainerSSCC).HasColumnName("FromContainerSSCC").HasMaxLength(30).IsRequired();
        builder.Property(p => p.ToContainerSSCC).HasColumnName("ToContainerSSCC").HasMaxLength(30).IsRequired();
        builder.Property(p => p.FromContainerTypeId).HasColumnName("FromContainerTypeId").IsRequired();
        builder.Property(p => p.ToContainerTypeId).HasColumnName("ToContainerTypeId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.LogStockId, p.FromContainerId, p.ToContainerId, p.FromContainerSSCC, p.ToContainerSSCC, p.FromContainerTypeId, p.ToContainerTypeId, p.CreatedDate }, name: "IX_LogStockContainers_Areas");
        #endregion

        #region İlişki Tanımları

        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
