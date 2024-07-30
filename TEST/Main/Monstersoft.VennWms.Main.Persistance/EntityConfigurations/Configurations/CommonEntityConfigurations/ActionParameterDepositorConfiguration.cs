using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.CommonEntityConfigurations;

public class ActionParameterDepositorConfiguration : IEntityTypeConfiguration<ActionParameterDepositor>
{
    public void Configure(EntityTypeBuilder<ActionParameterDepositor> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("ActionParameterDepositors", "common").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.ActionParameterId).HasColumnName("ActionParameterId").IsRequired();
        builder.Property(p => p.DepositorId).HasColumnName("DepositorId").IsRequired();
        builder.Property(p => p.Value).HasColumnName("Value").HasMaxLength(60).IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.ActionParameterId, p.DepositorId, p.Value, p.CreatedDate }, name: "IX_ActionParameterDepositors_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.ActionParameter).WithMany(p => p.ActionParameterDepositors).HasForeignKey(p => p.ActionParameterId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.Depositor).WithMany().HasForeignKey(p => p.DepositorId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
