using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.StockEntityConfigurations;

public class StockContainerConfiguration : IEntityTypeConfiguration<StockContainer>
{
    public void Configure(EntityTypeBuilder<StockContainer> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("StockContainers", "stock").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Sscc).HasColumnName("Sscc").HasMaxLength(30).IsRequired();
        builder.Property(p => p.ContainerUnitId).HasColumnName("ContainerUnitId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.Sscc, p.ContainerUnitId, p.CreatedDate }, name: "IX_StockContainers_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.ContainerUnit).WithMany().HasForeignKey(p => p.ContainerUnitId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
