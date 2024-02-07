using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.LoggingEntityConfigurations;

public class LogStockUnsuitReasonConfiguration : IEntityTypeConfiguration<LogStockUnsuitReason>
{
    public void Configure(EntityTypeBuilder<LogStockUnsuitReason> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("LogStockUnsuitReasons").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.LogStockId).HasColumnName("LogStockId").IsRequired();
        builder.Property(p => p.FromResaonId).HasColumnName("FromResaonId").IsRequired();
        builder.Property(p => p.ToResaonId).HasColumnName("ToResaonId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");      
        #endregion

        #region Indexler
        
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.LogStock);
        builder.HasOne(p => p.FromReason);
        builder.HasOne(p => p.ToResaon);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
