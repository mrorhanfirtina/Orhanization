using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ShipmentEntityConfigurations;

public class ShipmentConfiguration : IEntityTypeConfiguration<Shipment>
{
    public void Configure(EntityTypeBuilder<Shipment> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("Shipments").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
        builder.Property(p => p.DepositorId).HasColumnName("DepositorId").IsRequired();
        builder.Property(p => p.DistirbutorId).HasColumnName("DistirbutorId").IsRequired();
        builder.Property(p => p.BranchId).HasColumnName("BranchId").IsRequired();
        builder.Property(p => p.ShipmentTypeId).HasColumnName("ShipmentTypeId").IsRequired();
        builder.Property(p => p.InputDate).HasColumnName("InputDate").IsRequired();
        builder.Property(p => p.ExpectedDate).HasColumnName("ExpectedDate");
        builder.Property(p => p.ActualDate).HasColumnName("ActualDate");
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(indexExpression: p => p.Code, name: "UK_Shipments_Code").IsUnique();
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.Disturbitor);
        builder.HasOne(p => p.Branch);
        builder.HasOne(p => p.ShipmentType);
        builder.HasMany(p => p.ShipmentAttributeValues);
        builder.HasMany(p => p.ShipmentMemos);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
