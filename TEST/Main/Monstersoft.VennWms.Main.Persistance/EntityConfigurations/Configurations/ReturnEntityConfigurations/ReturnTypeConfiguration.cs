using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ReturnEntityConfigurations;

public class ReturnTypeConfiguration : IEntityTypeConfiguration<ReturnType>
{
    public void Configure(EntityTypeBuilder<ReturnType> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("ReturnTypes").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
        builder.Property(p => p.Description).HasColumnName("Description").HasMaxLength(60).IsRequired();
        builder.Property(p => p.Format).HasColumnName("Format").HasMaxLength(20).IsRequired();
        builder.Property(p => p.Counter).HasColumnName("Counter").IsRequired();
        builder.Property(p => p.DepositorId).HasColumnName("DepositorId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(indexExpression: p => p.Code, name: "UK_ReturnTypes_Code").IsUnique();
        builder.HasIndex(indexExpression: p => p.Description, name: "UK_ReturnTypes_Description").IsUnique();
        #endregion

        #region İlişki Tanımları
        builder.HasMany(p => p.Returns);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
