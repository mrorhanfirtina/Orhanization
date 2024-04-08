using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.POEntityConfigurations;

public class PoTypeConfiguration : IEntityTypeConfiguration<PoType>
{
    public void Configure(EntityTypeBuilder<PoType> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("PoTypes").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
        builder.Property(p => p.Description).HasColumnName("Description").HasMaxLength(60).IsRequired();
        builder.Property(p => p.Format).HasColumnName("Format").HasMaxLength(20).IsRequired();
        builder.Property(p => p.Counter).HasColumnName("Counter").IsRequired();
        builder.Property(p => p.DepositorCompanyId).HasColumnName("DepositorCompanyId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.Code, p.Description, p.Format, p.Counter, p.DepositorCompanyId, p.CreatedDate }, name: "IX_PoTypes_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasMany(p => p.PurchaseOrders).WithOne().HasForeignKey(p => p.PoTypeId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.DepositorCompany).WithMany().HasForeignKey(p => p.DepositorCompanyId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
