using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.LocationEntityConfigurations;

public class BufferLocationConfiguration : IEntityTypeConfiguration<BufferLocation>
{
    public void Configure(EntityTypeBuilder<BufferLocation> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("BufferLocations", "location").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.LocationId).HasColumnName("LocationId").IsRequired();
        builder.Property(p => p.BuffLocationId).HasColumnName("BufferLocationId").IsRequired();
        builder.Property(p => p.IsBefore).HasColumnName("IsBefore").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.LocationId, p.BuffLocationId, p.IsBefore, p.CreatedDate }, name: "IX_BufferLocations_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.Location).WithMany().HasForeignKey(p => p.LocationId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.BuffLocation).WithMany().HasForeignKey(p => p.BuffLocationId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion

    }
}
