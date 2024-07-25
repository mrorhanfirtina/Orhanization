using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.CommonEntityConfigurations;

public class ActionParameterConfiguration : IEntityTypeConfiguration<ActionParameter>
{
    public void Configure(EntityTypeBuilder<ActionParameter> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("ActionParameters", "common").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired().UseIdentityColumn(1, 1);
        builder.Property(p => p.Name).HasColumnName("Name").HasMaxLength(60).IsRequired();
        builder.Property(p => p.Description).HasColumnName("Description").HasMaxLength(1000).IsRequired();
        builder.Property(p => p.DefaultValue).HasColumnName("DefaultValue").HasMaxLength(60).IsRequired();
        builder.Property(p => p.CategoryId).HasColumnName("CategoryId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.Name, p.CategoryId, p.DefaultValue, p.CreatedDate }, name: "IX_ActionParameters_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.ActionParameterCategory).WithMany(p => p.ActionParameters).HasForeignKey(p => p.CategoryId).OnDelete(DeleteBehavior.Restrict);
        builder.HasMany(p => p.ActionParameterUsers).WithOne(p => p.ActionParameter).HasForeignKey(p => p.ActionParameterId).OnDelete(DeleteBehavior.Restrict);
        builder.HasMany(p => p.ActionParameterDepositors).WithOne(p => p.ActionParameter).HasForeignKey(p => p.ActionParameterId).OnDelete(DeleteBehavior.Restrict);
        builder.HasMany(p => p.ActionParameterDefaults).WithOne(p => p.ActionParameter).HasForeignKey(p => p.ActionParameterId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
