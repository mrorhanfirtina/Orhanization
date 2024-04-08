using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds;

public class SiteSeed : IEntityTypeConfiguration<Site>
{
    public void Configure(EntityTypeBuilder<Site> builder)
    {
        builder.HasData(
            new Site
            {
                Id = Guid.Parse("f769e1ec-71cd-450b-80aa-1b863e518a26"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                Description = "MAIN SITE",
                Code = "MAIN",
                CreatedDate = DateTime.Now,
            });
    }
}
