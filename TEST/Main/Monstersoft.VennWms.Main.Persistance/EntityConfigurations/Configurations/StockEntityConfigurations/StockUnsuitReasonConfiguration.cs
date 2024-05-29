using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.StockEntityConfigurations;

public class StockUnsuitReasonConfiguration : IEntityTypeConfiguration<StockUnsuitReason>
{
    public void Configure(EntityTypeBuilder<StockUnsuitReason> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("StockUnsuitReasons", "stock").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.StockId).HasColumnName("StockId").IsRequired();
        builder.Property(p => p.UnsuitReasonId).HasColumnName("UnsuitReasonId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.StockId, p.UnsuitReasonId, p.CreatedDate }, name: "IX_StockUnsuitReason_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.UnsuitReason).WithMany().HasForeignKey(p => p.UnsuitReasonId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
