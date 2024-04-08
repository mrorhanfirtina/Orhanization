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
        builder.Property(p => p.AddressId).HasColumnName("AddressId").IsRequired();
        builder.Property(p => p.CustomerId).HasColumnName("CustomerId").IsRequired();
        builder.Property(p => p.DepositorCompanyId).HasColumnName("DepositorCompanyId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.Code, p.Name, p.AddressId, p.CustomerId, p.DepositorCompanyId, p.CreatedDate }, name: "IX_Receivers_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.Address).WithOne().HasForeignKey<Receiver>(p => p.AddressId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(p => p.Customer).WithMany().HasForeignKey(p => p.CustomerId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.DepositorCompany).WithMany().HasForeignKey(p => p.DepositorCompanyId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
