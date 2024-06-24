using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ShipmentEntitySeed;

public class ShipmentAttributeValueSeed : IEntityTypeConfiguration<ShipmentAttributeValue>
{
    public void Configure(EntityTypeBuilder<ShipmentAttributeValue> builder)
    {
        builder.HasData(
        new ShipmentAttributeValue
        {
            Id = Guid.Parse("c2b4911c-296d-4b32-b178-cd9509110a69"),
            ShipmentId = Guid.Parse("94b82659-a683-4965-accc-bc5d5aaf713b"),
            ShipmentAttributeId = Guid.Parse("f507a0bb-9c44-49d1-a32f-70cbcafc4613"),
            Value = "34 BJK 1903",
            CreatedDate = DateTime.Now,
        }

        );
    }
}
