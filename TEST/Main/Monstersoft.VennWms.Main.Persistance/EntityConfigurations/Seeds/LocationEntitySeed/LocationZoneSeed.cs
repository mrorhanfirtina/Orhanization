using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.LocationEntitySeed;

public class LocationZoneSeed : IEntityTypeConfiguration<LocationZone>
{
    public void Configure(EntityTypeBuilder<LocationZone> builder)
    {
        builder.HasData(
        new LocationZone
        {
            Id = Guid.Parse("8c78c92d-3718-4cdc-9182-73bb2f291803"),
            LocationId = Guid.Parse("2857A1B2-6385-4BC0-83D1-38AB382D7073"),
            ZoneId = Guid.Parse("57484d8d-8e61-434d-acfd-c902948df0fc"),
            CreatedDate = DateTime.Now,
        },
        new LocationZone
        {
            Id = Guid.Parse("80212274-3f79-4627-9775-4924e43ee4e6"),
            LocationId = Guid.Parse("4A67A504-A790-4CA1-B6D7-F23C0C25371D"),
            ZoneId = Guid.Parse("57484d8d-8e61-434d-acfd-c902948df0fc"),
            CreatedDate = DateTime.Now,
        }

        );
    }
}
