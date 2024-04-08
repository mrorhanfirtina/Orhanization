using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.CommonEntityConfigurations;

public class LocationCodeComponentConfiguration : IEntityTypeConfiguration<LocationCodeComponent>
{
    public void Configure(EntityTypeBuilder<LocationCodeComponent> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("LocationCodeComponents").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired().UseIdentityColumn(1, 1);
        builder.Property(p => p.Description).HasColumnName("Description").HasMaxLength(30).IsRequired();
        builder.Property(p => p.TableName).HasColumnName("TableName").HasMaxLength(30).IsRequired();
        builder.Property(p => p.FieldName).HasColumnName("FieldName").HasMaxLength(30).IsRequired();
        builder.Property(p => p.FieldCode).HasColumnName("FieldCode").HasMaxLength(10).IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.Description, p.TableName, p.FieldName, p.FieldCode, p.CreatedDate }, name: "IX_LocationCodeComponents_Areas");
        builder.HasIndex(indexExpression: p => p.Description).IsUnique();
        #endregion

        #region İlişki Tanımları

        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}