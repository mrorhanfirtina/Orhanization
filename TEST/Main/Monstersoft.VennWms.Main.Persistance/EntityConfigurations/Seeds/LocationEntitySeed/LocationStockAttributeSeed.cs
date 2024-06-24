using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.LocationEntitySeed;

public class LocationStockAttributeSeed : IEntityTypeConfiguration<LocationStockAttribute>
{
    public void Configure(EntityTypeBuilder<LocationStockAttribute> builder)
    {
        builder.HasData(
            new LocationStockAttribute
            {
                Id = Guid.Parse("8e2976b4-1738-438b-807b-2279dad72919"),
                LocationId = Guid.Parse("8395A6ED-93B9-412E-BB17-24817F28478A"),
                StockAttributeId = Guid.Parse("eacd5b95-2e35-4b2e-8a9a-33da04bfdb76"),
                Value = "1",
                IsForbid = false,
                CreatedDate = DateTime.Now,
            },
            new LocationStockAttribute
            {
                Id = Guid.Parse("e4280706-cf66-48b5-967c-ff4b8969e1cd"),
                LocationId = Guid.Parse("F4FE04A5-224D-4D6C-A29C-293E636685B2"),
                StockAttributeId = Guid.Parse("eacd5b95-2e35-4b2e-8a9a-33da04bfdb76"),
                Value = "0",
                IsForbid = false,
                CreatedDate = DateTime.Now,
            },
            new LocationStockAttribute
            {
                Id = Guid.Parse("93131b82-b6ea-4afb-a4ce-bdd16564d9f3"),
                LocationId = Guid.Parse("43336C29-8B2A-4B47-A4F3-2B74EB18A7D5"),
                StockAttributeId = Guid.Parse("eacd5b95-2e35-4b2e-8a9a-33da04bfdb76"),
                Value = "1",
                IsForbid = false,
                CreatedDate = DateTime.Now,
            }

            );
    }
}
