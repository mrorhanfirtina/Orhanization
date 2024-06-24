using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.LocationEntitySeed;

public class LocationLockReasonSeed : IEntityTypeConfiguration<LocationLockReason>
{
    public void Configure(EntityTypeBuilder<LocationLockReason> builder)
    {
        builder.HasData(
            new LocationLockReason
            {
                Id = Guid.Parse("e80b7b8b-ffe5-4649-b820-bb129925edb4"),
                LocationId = Guid.Parse("D57C5F10-9BA9-4AD8-B6CD-09EE15DF598A"),
                LockReasonId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationLockReason
            {
                Id = Guid.Parse("d539cc48-93d2-4d1e-a941-39a9298bf961"),
                LocationId = Guid.Parse("09CB7B29-24A5-44D5-8994-0A1170EE0179"),
                LockReasonId = 3,
                CreatedDate = DateTime.Now,
            }

        );
    }
}
