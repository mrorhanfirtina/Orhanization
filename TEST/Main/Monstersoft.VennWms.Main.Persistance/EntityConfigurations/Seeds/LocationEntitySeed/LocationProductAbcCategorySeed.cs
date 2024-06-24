using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.LocationEntitySeed;

public class LocationProductAbcCategorySeed : IEntityTypeConfiguration<LocationProductAbcCategory>
{
    public void Configure(EntityTypeBuilder<LocationProductAbcCategory> builder)
    {
        builder.HasData(
            new LocationProductAbcCategory
            {
                Id = Guid.Parse("7c8e1add-c1d6-4b2c-8714-89c7912d8f72"),
                LocationId = Guid.Parse("29E6E644-EE1C-4814-A915-DD8A576DEB70"),
                AbcCategoryId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationProductAbcCategory
            {
                Id = Guid.Parse("049a6678-db22-4a0c-87a1-057f83c7ebaa"),
                LocationId = Guid.Parse("B9B76C44-D266-48F0-8BC7-DEF8404E6806"),
                AbcCategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationProductAbcCategory
            {
                Id = Guid.Parse("86783209-5414-4bed-a906-90bad2157eae"),
                LocationId = Guid.Parse("5C2758A6-5BAF-4F99-87CD-3912E7F5BE70"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            }
            );
    }
}
