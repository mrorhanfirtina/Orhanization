using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds;

public class BuildingSeed : IEntityTypeConfiguration<Building>
{
    public void Configure(EntityTypeBuilder<Building> builder)
    {
        builder.HasData(
                new Building
                {
                    Id = Guid.Parse("6b94bdfe-4158-4e98-816e-a3422816b2a3"),
                    Code = "MAIN",
                    Country = "Turkey",
                    City = "Istanbul",
                    AddressText = "Deri Org. San. Bolgesi No:26",
                    Province = "Tuzla",
                    CreatedDate = DateTime.Now,
                    Description = "Main Factory",
                    ZipCode = "34953",
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    SiteId = Guid.Parse("f769e1ec-71cd-450b-80aa-1b863e518a26"),
                    Latitude = 40.8503m,
                    Longitude = 29.3032m
                }
            );
    }
}
