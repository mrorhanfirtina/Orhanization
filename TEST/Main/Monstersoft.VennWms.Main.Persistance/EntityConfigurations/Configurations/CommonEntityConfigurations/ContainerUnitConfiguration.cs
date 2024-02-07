using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using System.ComponentModel;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.CommonEntityConfigurations;

public class ContainerUnitConfiguration : IEntityTypeConfiguration<ContainerUnit>
{
    public void Configure(EntityTypeBuilder<ContainerUnit> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("ContainerUnits").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired().UseIdentityColumn(1,1);
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
        builder.Property(p => p.Description).HasColumnName("Description").HasMaxLength(60).IsRequired();
        builder.Property(p => p.FirstDigit).HasColumnName("FirstDigit").HasMaxLength(1).IsRequired();
        builder.Property(p => p.CountryCode).HasColumnName("CountryCode").HasMaxLength(2).IsRequired();
        builder.Property(p => p.ProducerCode).HasColumnName("ProducerCode").HasMaxLength(7).IsRequired();
        builder.Property(p => p.Counter).HasColumnName("Counter").HasMaxLength(7).IsRequired();
        builder.Property(p => p.DepositorId).HasColumnName("DepositorId").IsRequired();
        #endregion

        #region Indexler
        
        #endregion

        #region İlişki Tanımları
        
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
