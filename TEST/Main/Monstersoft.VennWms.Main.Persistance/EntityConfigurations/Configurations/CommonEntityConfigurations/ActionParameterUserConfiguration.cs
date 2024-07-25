using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.CommonEntityConfigurations;

public class ActionParameterUserConfiguration : IEntityTypeConfiguration<ActionParameterUser>
{
    public void Configure(EntityTypeBuilder<ActionParameterUser> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("ActionParameterUsers", "common").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.ActionParameterId).HasColumnName("ActionParameterId").IsRequired();
        builder.Property(p => p.UserId).HasColumnName("UserId").IsRequired();
        builder.Property(p => p.Value).HasColumnName("Value").HasMaxLength(60).IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.ActionParameterId, p.UserId, p.Value, p.CreatedDate }, name: "IX_ActionParameterUsers_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.ActionParameter).WithMany(p => p.ActionParameterUsers).HasForeignKey(p => p.ActionParameterId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.User).WithMany().HasForeignKey(p => p.UserId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
