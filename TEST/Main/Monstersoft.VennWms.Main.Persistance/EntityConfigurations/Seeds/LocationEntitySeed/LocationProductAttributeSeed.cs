using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.LocationEntitySeed;

public class LocationProductAttributeSeed : IEntityTypeConfiguration<LocationProductAttribute>
{
    public void Configure(EntityTypeBuilder<LocationProductAttribute> builder)
    {
        builder.HasData(
        new LocationProductAttribute
        {
            Id = Guid.Parse("e71e2e2a-7269-448c-8438-6e7e1176d4b8"),
            LocationId = Guid.Parse("68BE3CE8-6174-43D4-A145-2A97DD7DE349"),
            ProductAttributeId = Guid.Parse("39e6e6c2-5d91-40a8-923a-64500f4b14d7"),
            IsForbid = false,
            Value = "1",
            CreatedDate = DateTime.Now,
        },
        new LocationProductAttribute
        {
            Id = Guid.Parse("7b71e28a-053c-432e-a1c4-0a0e2eaaabb9"),
            LocationId = Guid.Parse("43336C29-8B2A-4B47-A4F3-2B74EB18A7D5"),
            ProductAttributeId = Guid.Parse("39e6e6c2-5d91-40a8-923a-64500f4b14d7"),
            IsForbid = false,
            Value = "0",
            CreatedDate = DateTime.Now,
        },
        new LocationProductAttribute
        {
            Id = Guid.Parse("82b26fb2-ad18-4d6d-a517-a69a9a5b5b2c"),
            LocationId = Guid.Parse("86867DC0-4575-44EE-BDE0-2F9DE986BF4E"),
            ProductAttributeId = Guid.Parse("39e6e6c2-5d91-40a8-923a-64500f4b14d7"),
            IsForbid = false,
            Value = "1",
            CreatedDate = DateTime.Now,
        }
        );
    }
}
