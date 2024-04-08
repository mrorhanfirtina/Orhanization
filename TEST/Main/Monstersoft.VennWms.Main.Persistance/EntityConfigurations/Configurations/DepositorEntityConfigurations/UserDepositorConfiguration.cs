using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.DepositorEntityConfigurations;

public class UserDepositorConfiguration : IEntityTypeConfiguration<UserDepositor>
{
    public void Configure(EntityTypeBuilder<UserDepositor> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("UserDepositors").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.UserId).HasColumnName("UserId").IsRequired();
        builder.Property(p => p.DepositorId).HasColumnName("DepositorId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.DepositorId, p.UserId, p.CreatedDate }, name: "IX_UserDepositors_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.User).WithMany().HasForeignKey(p => p.UserId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(p => p.Depositor).WithMany().HasForeignKey(p => p.DepositorId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion

    }
}
