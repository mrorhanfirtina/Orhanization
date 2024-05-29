using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.LocationEntitySeed;

public class ZoneSeed : IEntityTypeConfiguration<Zone>
{
    public void Configure(EntityTypeBuilder<Zone> builder)
    {
        builder.HasData(
            new Zone
            {
                Id = Guid.Parse("57484d8d-8e61-434d-acfd-c902948df0fc"),
                Code = "WT",
                Description = "Waiting Zone",
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
            }

            );
    }
}
