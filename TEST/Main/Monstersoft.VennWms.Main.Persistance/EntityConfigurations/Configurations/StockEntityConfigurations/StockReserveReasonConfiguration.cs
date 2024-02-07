using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.StockEntityConfigurations;

public class StockReserveReasonConfiguration : IEntityTypeConfiguration<StockReserveReason>
{
    public void Configure(EntityTypeBuilder<StockReserveReason> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("StockReserveReasons").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.StockId).HasColumnName("StockId").IsRequired();
        builder.Property(p => p.ReserveReasonId).HasColumnName("ReserveReasonId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.Stock);
        builder.HasOne(p => p.ReserveReason);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
