using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.DepositorEntityConfigurations;

public class ReceiverConfiguration : IEntityTypeConfiguration<Receiver>
{
    public void Configure(EntityTypeBuilder<Receiver> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("Receivers").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(30).IsRequired();
        builder.Property(p => p.Name).HasColumnName("Name").HasMaxLength(120).IsRequired();
        builder.Property(p => p.BuildingId).HasColumnName("BuildingId").IsRequired();
        builder.Property(p => p.CustomerId).HasColumnName("CustomerId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(indexExpression: p => p.Code, name: "UK_Receivers_Code").IsUnique();
        builder.HasIndex(indexExpression: p => p.Name, name: "UK_Receivers_Name").IsUnique();
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.Building);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
