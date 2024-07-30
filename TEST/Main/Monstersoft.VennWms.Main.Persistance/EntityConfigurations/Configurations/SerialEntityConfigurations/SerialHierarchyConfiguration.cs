using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.SerialEntityConfigurations;

public class SerialHierarchyConfiguration : IEntityTypeConfiguration<SerialHierarchy>
{
    public void Configure(EntityTypeBuilder<SerialHierarchy> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("SerialHierarchies", "serial").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.RootSerialId).HasColumnName("RootSerialId").IsRequired();
        builder.Property(p => p.ChildSerialId).HasColumnName("ChildSerialId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.RootSerialId, p.ChildSerialId, p.CreatedDate }, name: "IX_SerialHierarchies_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.RootSerial).WithMany(p => p.SerialHierarchies).HasForeignKey(p => p.RootSerialId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.ChildSerial).WithMany().HasForeignKey(p => p.ChildSerialId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion

    }
}
