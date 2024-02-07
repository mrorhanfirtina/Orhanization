using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.ReturnEntityConfigurations;

public class ReturnConfiguration : IEntityTypeConfiguration<Return>
{
    public void Configure(EntityTypeBuilder<Return> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("Returns").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
        builder.Property(p => p.CustomerId).HasColumnName("CustomerId").IsRequired();
        builder.Property(p => p.StatusId).HasColumnName("StatusId").IsRequired();
        builder.Property(p => p.DepositorId).HasColumnName("DepositorId").IsRequired();
        builder.Property(p => p.ReturnTypeId).HasColumnName("ReturnTypeId").IsRequired();
        builder.Property(p => p.InputDate).HasColumnName("InputDate").IsRequired();
        builder.Property(p => p.ExpectedDate).HasColumnName("ExpectedDate");
        builder.Property(p => p.ReceiveDate).HasColumnName("ReceiveDate");
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(indexExpression: p => p.Code, name: "UK_Returns_Code").IsUnique();
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.Customer);
        builder.HasOne(p => p.ReturnType);
        builder.HasMany(p => p.TransactionLogs);
        builder.HasMany(p => p.ReturnAttributeValues);
        builder.HasMany(p => p.ReturnItems);
        builder.HasMany(p => p.ReturnMemos);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}

