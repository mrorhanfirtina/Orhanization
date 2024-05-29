using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.DepositorEntityConfigurations;

public class DepositorFeatureConfiguration : IEntityTypeConfiguration<DepositorFeature>
{
    public void Configure(EntityTypeBuilder<DepositorFeature> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("DepositorFeatures", "depositor").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.DepositorId).HasColumnName("DepositorId").IsRequired();
        builder.Property(p => p.GenerateSsccLed).HasColumnName("GenerateSsccLed").HasDefaultValue(false).IsRequired();
        builder.Property(p => p.OrderModifyLed).HasColumnName("OrderModifyLed").HasDefaultValue(false).IsRequired();
        builder.Property(p => p.ForbidTransferReservedLed).HasColumnName("ForbidTransferReservedLed").HasDefaultValue(false).IsRequired();
        builder.Property(p => p.ForbidNewReceiptLineLed).HasColumnName("ForbidNewReceiptLineLed").HasDefaultValue(false).IsRequired();
        builder.Property(p => p.AllowDuplicateBarcodeLed).HasColumnName("AllowDuplicateBarcodeLed").HasDefaultValue(false).IsRequired();
        builder.Property(p => p.ForceTaskStockLed).HasColumnName("ForceTaskStockLed").HasDefaultValue(false).IsRequired();
        builder.Property(p => p.ChangeStockWithTaskLed).HasColumnName("ChangeStockWithTaskLed").HasDefaultValue(false).IsRequired();
        builder.Property(p => p.ManualReceiptCompletionLed).HasColumnName("ManualReceiptCompletionLed").HasDefaultValue(false).IsRequired();
        builder.Property(p => p.ManualReturnCompletionLed).HasColumnName("ManualReturnCompletionLed").HasDefaultValue(false).IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.DepositorId, p.CreatedDate }, name: "IX_DepositorFeatures_Areas");
        #endregion

        #region İlişki Tanımları

        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
