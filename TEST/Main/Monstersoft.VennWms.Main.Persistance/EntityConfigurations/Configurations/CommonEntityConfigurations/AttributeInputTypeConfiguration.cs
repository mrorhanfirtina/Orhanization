using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        builder.HasIndex(indexExpression: p => p.Description, name: "UK_AttributeInputTypes_Description").IsUnique();
        #endregion

        #region İlişki Tanımları
        builder.HasMany(p => p.OrderAttributes);
        builder.HasMany(p => p.PoAttributes);
        builder.HasMany(p => p.ProductAttributes);
        builder.HasMany(p => p.ReceiptAttributes);
        builder.HasMany(p => p.ReturnAttributes);
        builder.HasMany(p => p.ShipmentAttributes);
        builder.HasMany(p => p.StockAttributes);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
