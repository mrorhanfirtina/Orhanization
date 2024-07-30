using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.StockEntityConfigurations;

public class StockContainerHierarchyConfiguration : IEntityTypeConfiguration<StockContainerHierarchy>
{
    public void Configure(EntityTypeBuilder<StockContainerHierarchy> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("StockContainerHierarchies", "stock").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.ParentContainerId).HasColumnName("ParentContainerId").IsRequired();
        builder.Property(p => p.ChildContainerId).HasColumnName("ChildContainerId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.ParentContainerId, p.ChildContainerId, p.CreatedDate }, name: "IX_StockContainerHierarchies_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.ParentContainer).WithMany().HasForeignKey(p => p.ParentContainerId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.ChildContainer).WithMany().HasForeignKey(p => p.ChildContainerId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion

    }
}