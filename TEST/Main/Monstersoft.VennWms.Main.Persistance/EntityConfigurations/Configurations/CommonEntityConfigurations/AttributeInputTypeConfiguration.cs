using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.CommonEntityConfigurations;

public class AttributeInputTypeConfiguration : IEntityTypeConfiguration<AttributeInputType>
{
    public void Configure(EntityTypeBuilder<AttributeInputType> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("AttributeInputTypes").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired().UseIdentityColumn(1,1);
        builder.Property(p => p.Description).HasColumnName("Description").HasMaxLength(50).IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.Description, p.CreatedDate }, name: "IX_AttributeInputTypes_Areas");
        builder.HasIndex(indexExpression: p => p.Description, name: "UK_AttributeInputTypes_Description").IsUnique();
        #endregion

        #region İlişki Tanımları

        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
