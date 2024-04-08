using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds;

public class BuildingDimensionSeed : IEntityTypeConfiguration<BuildingDimension>
{
    public void Configure(EntityTypeBuilder<BuildingDimension> builder)
    {
        builder.HasData(
                new BuildingDimension
                {
                    Id = Guid.Parse("daf214c4-92e9-4e93-989b-4fa1c2ecf793"),
                    BuildingId = Guid.Parse("6b94bdfe-4158-4e98-816e-a3422816b2a3"),
                    Height = 10,
                    Width = 20,
                    Length = 30,
                    LenghtUnitId = 2,
                    VolumeUnitId = 3,
                    Volume = 6000,
                    CreatedDate = DateTime.Now
                }
            );
    }
}
