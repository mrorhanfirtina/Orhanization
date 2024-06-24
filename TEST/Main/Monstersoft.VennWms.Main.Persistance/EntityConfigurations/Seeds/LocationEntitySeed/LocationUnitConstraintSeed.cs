using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.LocationEntitySeed;

public class LocationUnitConstraintSeed : IEntityTypeConfiguration<LocationUnitConstraint>
{
    public void Configure(EntityTypeBuilder<LocationUnitConstraint> builder)
    {
        builder.HasData(
            new LocationUnitConstraint
            {
                Id = Guid.Parse("aa70fa90-5ceb-4247-a45a-294d824c3444"),
                LocationId = Guid.Parse("E2985273-7435-46DF-AAFE-0BA0F8FA1246"),
                UnitId = 33,
                Capacity = 1000,
                CreatedDate = DateTime.Now,
            }

        );
    }
}
