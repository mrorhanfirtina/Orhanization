using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.StockEntityConfigurations;

public class TaskStockConfiguration : IEntityTypeConfiguration<TaskStock>
{
    public void Configure(EntityTypeBuilder<TaskStock> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("TaskStocks", "stock").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.WorkTaskId).HasColumnName("WorkTaskId").IsRequired();
        builder.Property(p => p.StockId).HasColumnName("StockId").IsRequired();
        builder.Property(p => p.Quantity).HasColumnName("Quantity").HasColumnType("DECIMAL(18,6)").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.WorkTaskId, p.StockId, p.Quantity, p.CreatedDate }, name: "IX_TaskStocks_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.WorkTask).WithMany().HasForeignKey(p => p.WorkTaskId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(p => p.Stock).WithMany().HasForeignKey(p => p.StockId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
