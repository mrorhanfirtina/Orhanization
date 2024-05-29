using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.LocationEntitySeed;

public class SiteSeed : IEntityTypeConfiguration<Site>
{
    public void Configure(EntityTypeBuilder<Site> builder)
    {
        builder.HasData(
            new Site
            {
                Id = Guid.Parse("f769e1ec-71cd-450b-80aa-1b863e518a26"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                Description = "Sony Main Site",
                Code = "SONYMAIN",
                CreatedDate = DateTime.Now,
            },
            new Site
            {
                Id = Guid.Parse("2cde8f81-f01b-4e40-ad08-62e105ab0712"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                Description = "Sony Second Site",
                Code = "SONYSECOND",
                CreatedDate = DateTime.Now,
            },
            new Site
            {
                Id = Guid.Parse("47c488ad-1a7b-4d9d-97c1-838eb01e510e"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                Description = "Sony Third Site",
                Code = "SONYTHIRD",
                CreatedDate = DateTime.Now,
            }
            );
    }
}
