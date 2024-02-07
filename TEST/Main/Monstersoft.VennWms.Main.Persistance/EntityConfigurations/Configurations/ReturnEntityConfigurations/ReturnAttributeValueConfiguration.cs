using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ReturnEntityConfigurations;

public class ReturnAttributeValueConfiguration : IEntityTypeConfiguration<ReturnAttributeValue>
{
    public void Configure(EntityTypeBuilder<ReturnAttributeValue> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("ReturnAttributeValues").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.ReturnId).HasColumnName("ReturnId").IsRequired();
        builder.Property(p => p.ReturnAttributeId).HasColumnName("ReturnAttributeId").IsRequired();
        builder.Property(p => p.Value).HasColumnName("Value").HasMaxLength(120).IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler

        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.Return);
        builder.HasOne(p => p.ReturnAttribute);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
