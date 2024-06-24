using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ShipmentEntityConfigurations;

public class ShipmentConfiguration : IEntityTypeConfiguration<Shipment>
{
    public void Configure(EntityTypeBuilder<Shipment> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("Shipments", "shipment").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
        builder.Property(p => p.DepositorId).HasColumnName("DepositorId").IsRequired();
        builder.Property(p => p.DepositorCompanyId).HasColumnName("DepositorCompanyId").IsRequired();
        builder.Property(p => p.DistributorId).HasColumnName("DistributorId").IsRequired();
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
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.Code, p.DepositorId, p.DepositorCompanyId, p.DistributorId, p.BranchId, p.ShipmentTypeId, p.InputDate, p.ExpectedDate, p.ActualDate, p.CreatedDate }, name: "IX_Shipments_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.Distributor).WithMany().HasForeignKey(p => p.DistributorId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.Branch).WithMany().HasForeignKey(p => p.BranchId).OnDelete(DeleteBehavior.Restrict);
        builder.HasMany(p => p.ShipmentAttributeValues).WithOne(p => p.Shipment).HasForeignKey(p => p.ShipmentId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.ShipmentMemos).WithOne(p => p.Shipment).HasForeignKey(p => p.ShipmentId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(p => p.Depositor).WithMany().HasForeignKey(p => p.DepositorId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.DepositorCompany).WithMany().HasForeignKey(p => p.DepositorCompanyId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
