using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.LoggingEntityConfigurations;

public class LogStockReserveReasonConfiguration : IEntityTypeConfiguration<LogStockReserveReason>
{
    public void Configure(EntityTypeBuilder<LogStockReserveReason> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("LogStockReserveReasons").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.LogStockId).HasColumnName("LogStockId").IsRequired();
        builder.Property(p => p.FromReasaonId).HasColumnName("FromReasaonId");
        builder.Property(p => p.ToReasaonId).HasColumnName("ToReasaonId");
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.LogStockId, p.FromReasaonId, p.ToReasaonId, p.CreatedDate }, name: "IX_LogStockReserveReasons_Areas");
        #endregion

        #region İlişki Tanımları

        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
