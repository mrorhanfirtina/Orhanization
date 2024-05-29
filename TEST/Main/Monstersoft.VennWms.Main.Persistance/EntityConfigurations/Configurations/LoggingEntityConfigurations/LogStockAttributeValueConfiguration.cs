using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.LoggingEntityConfigurations;

public class LogStockAttributeValueConfiguration : IEntityTypeConfiguration<LogStockAttributeValue>
{
    public void Configure(EntityTypeBuilder<LogStockAttributeValue> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("LogStockAttributeValues", "logging").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.LogStockId).HasColumnName("LogStockId").IsRequired();
        builder.Property(p => p.StockAttributeId).HasColumnName("StockAttributeId").IsRequired();
        builder.Property(p => p.FromValue).HasColumnName("FromValue").HasMaxLength(60);
        builder.Property(p => p.ToValue).HasColumnName("ToValue").HasMaxLength(60);
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.LogStockId, p.StockAttributeId, p.FromValue, p.ToValue, p.CreatedDate }, name: "IX_LogStockAttributeValues_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.StockAttribute).WithMany().HasForeignKey(p => p.StockAttributeId).OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
