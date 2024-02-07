using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ReturnEntityConfigurations;

public class ReturnItemConfiguration : IEntityTypeConfiguration<ReturnItem>
{
    public void Configure(EntityTypeBuilder<ReturnItem> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("ReturnItems").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.ReturnId).HasColumnName("ReturnId").IsRequired();
        builder.Property(p => p.ProductId).HasColumnName("ProductId").IsRequired();
        builder.Property(p => p.UnitId).HasColumnName("UnitId").IsRequired();
        builder.Property(p => p.StatusId).HasColumnName("StatusId").IsRequired();
        builder.Property(p => p.ExpectedQuantity).HasColumnName("ExpectedQuantity").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.ActualQuantity).HasColumnName("ActualQuantity").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler

        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.Return);
        builder.HasOne(p => p.Product);
        builder.HasOne(p => p.Unit);
        builder.HasMany(p => p.ReturnItemMemos);
        #endregion

    }
}
