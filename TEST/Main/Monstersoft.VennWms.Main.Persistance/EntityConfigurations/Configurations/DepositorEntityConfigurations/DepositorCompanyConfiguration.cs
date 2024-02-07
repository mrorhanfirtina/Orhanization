using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.DepositorEntityConfigurations;

public class DepositorCompanyConfiguration : IEntityTypeConfiguration<DepositorCompany>
{
    public void Configure(EntityTypeBuilder<DepositorCompany> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("DepositorCompanies").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
        builder.Property(p => p.Name).HasColumnName("Name").HasMaxLength(120).IsRequired();
        builder.Property(p => p.Description).HasColumnName("Description").HasMaxLength(120);
        builder.Property(p => p.TaxOffice).HasColumnName("TaxOffice").HasMaxLength(30);
        builder.Property(p => p.TaxNumber).HasColumnName("TaxNumber").HasMaxLength(30);
        builder.Property(p => p.PhoneNumber).HasColumnName("PhoneNumber").HasMaxLength(15);
        builder.Property(p => p.FaxNumber).HasColumnName("FaxNumber").HasMaxLength(15);
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(indexExpression: p => p.Code, name: "UK_DepositorCompanies_Code").IsUnique();
        builder.HasIndex(indexExpression: p => p.Name, name: "UK_DepositorCompanies_Name").IsUnique();
        #endregion

        #region İlişki Tanımları
        builder.HasMany(p => p.Depositors);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
