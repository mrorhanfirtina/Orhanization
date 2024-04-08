using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.CommonEntityConfigurations;

public class LockReasonConfiguration : IEntityTypeConfiguration<LockReason>
{
    public void Configure(EntityTypeBuilder<LockReason> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("LockReasons").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired().UseIdentityColumn(1, 1);
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
        builder.Property(p => p.Description).HasColumnName("Description").HasMaxLength(60).IsRequired();
        builder.Property(p => p.DepositorCompanyId).HasColumnName("DepositorCompanyId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.Code, p.Description, p.DepositorCompanyId, p.CreatedDate }, name: "IX_LockReasons_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.DepositorCompany).WithMany().HasForeignKey(p => p.DepositorCompanyId);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
