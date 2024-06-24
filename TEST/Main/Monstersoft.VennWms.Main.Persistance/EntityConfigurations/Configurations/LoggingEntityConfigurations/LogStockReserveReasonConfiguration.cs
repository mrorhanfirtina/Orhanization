using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.LoggingEntityConfigurations;

public class LogStockReserveReasonConfiguration : IEntityTypeConfiguration<LogStockReserveReason>
{
    public void Configure(EntityTypeBuilder<LogStockReserveReason> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("LogStockReserveReasons", "logging").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.LogStockId).HasColumnName("LogStockId").IsRequired();
        builder.Property(p => p.FromReasonId).HasColumnName("FromReasonId");
        builder.Property(p => p.ToReasonId).HasColumnName("ToReasonId");
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.LogStockId, p.FromReasonId, p.ToReasonId, p.CreatedDate }, name: "IX_LogStockReserveReasons_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.FromReason).WithMany().HasForeignKey(p => p.FromReasonId).OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(p => p.ToReason).WithMany().HasForeignKey(p => p.ToReasonId).OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
