using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.LocationEntitySeed;

public class LocationProductCategorySeed : IEntityTypeConfiguration<LocationProductCategory>
{
    public void Configure(EntityTypeBuilder<LocationProductCategory> builder)
    {
        builder.HasData(
            new LocationProductCategory
            {
                Id = Guid.Parse("973078b7-5733-449f-82d1-cb59a8320541"),
                LocationId = Guid.Parse("27EE14B0-A3BD-40B2-8061-32D420F7409C"),
                CategoryId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationProductCategory
            {
                Id = Guid.Parse("91079ef5-b8b8-478e-a54a-622efd8cb7cf"),
                LocationId = Guid.Parse("EA4C8E3E-E974-4C44-A911-3472C46A2DB3"),
                CategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationProductCategory
            {
                Id = Guid.Parse("a4ec293c-12ef-48ca-8992-fa6b3573d034"),
                LocationId = Guid.Parse("05D8F377-E968-4819-8FA1-3688DC226F6C"),
                CategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationProductCategory
            {
                Id = Guid.Parse("f94419c0-2e0a-4717-8161-63fc4a0591f8"),
                LocationId = Guid.Parse("E0E00F38-62F4-4420-91D3-1C2F80349AEF"),
                CategoryId = 3,
                CreatedDate = DateTime.Now,
            }

            );
    }
}
