using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.LocationEntitySeed;

public class BuildingDimensionSeed : IEntityTypeConfiguration<BuildingDimension>
{
    public void Configure(EntityTypeBuilder<BuildingDimension> builder)
    {
        builder.HasData(
                new BuildingDimension
                {
                    Id = Guid.Parse("e92cca51-57bc-411e-8b0a-90468c8d8f08"),
                    BuildingId = Guid.Parse("6b94bdfe-4158-4e98-816e-a3422816b2a3"),
                    Height = 50,
                    Width = 100,
                    Length = 600,
                    LenghtUnitId = 4,
                    VolumeUnitId = 15,
                    Volume = 3000000,
                    CreatedDate = DateTime.Now
                },
                new BuildingDimension
                {
                    Id = Guid.Parse("1d82e9e6-5dda-4ae3-87cf-bcce3042fd0a"),
                    BuildingId = Guid.Parse("acc4558e-9492-4eec-9b31-9bdf31844740"),
                    Height = 30,
                    Width = 50,
                    Length = 300,
                    LenghtUnitId = 4,
                    VolumeUnitId = 15,
                    Volume = 450000,
                    CreatedDate = DateTime.Now
                },
                new BuildingDimension
                {
                    Id = Guid.Parse("ecc932d0-85c9-4d80-8186-01df6f4154b5"),
                    BuildingId = Guid.Parse("2ce97c33-78f5-46a9-94b8-668c53fbe49e"),
                    Height = 30,
                    Width = 30,
                    Length = 200,
                    LenghtUnitId = 4,
                    VolumeUnitId = 15,
                    Volume = 180000,
                    CreatedDate = DateTime.Now
                },
                new BuildingDimension
                {
                    Id = Guid.Parse("355cff09-28fb-479b-8ae2-2978e8c5ace7"),
                    BuildingId = Guid.Parse("0d240376-68a1-4f9c-904b-7ae8a4ce5150"),
                    Height = 30,
                    Width = 50,
                    Length = 250,
                    LenghtUnitId = 4,
                    VolumeUnitId = 15,
                    Volume = 375000,
                    CreatedDate = DateTime.Now
                }
            );
    }
}
