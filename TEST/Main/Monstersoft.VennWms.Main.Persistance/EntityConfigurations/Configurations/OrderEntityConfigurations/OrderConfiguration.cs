using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.OrderEntityConfigurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("Orders").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
        builder.Property(p => p.DepositorId).HasColumnName("DepositorId").IsRequired();
        builder.Property(p => p.CustomerId).HasColumnName("CustomerId").IsRequired();
        builder.Property(p => p.ReceiverId).HasColumnName("ReceiverId").IsRequired();
        builder.Property(p => p.OrderTypeId).HasColumnName("OrderTypeId").IsRequired();
        builder.Property(p => p.StatusId).HasColumnName("StatusId").IsRequired();
        builder.Property(p => p.InputDate).HasColumnName("InputDate").IsRequired();
        builder.Property(p => p.ExpectedDate).HasColumnName("ExpectedDate");
        builder.Property(p => p.ActualDate).HasColumnName("ActualDate");
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(indexExpression: p => p.Code, name: "UK_Orders_Code").IsUnique();
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.Status);
        builder.HasOne(p => p.Customer);
        builder.HasOne(p => p.OrderType);
        builder.HasMany(p => p.OrderAttributeValues);
        builder.HasMany(p => p.OrderItems);
        builder.HasMany(p => p.OrderMemos);
        builder.HasMany(p => p.TransactionLogs);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}


