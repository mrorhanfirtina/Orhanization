using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ShipmentEntitySeed;

public class ShipmentAttributeSeed : IEntityTypeConfiguration<ShipmentAttribute>
{
    public void Configure(EntityTypeBuilder<ShipmentAttribute> builder)
    {
        builder.HasData(
        new ShipmentAttribute
        {
            Id = Guid.Parse("f507a0bb-9c44-49d1-a32f-70cbcafc4613"),
            Code = "SA01",
            Description = "Truck Plate Number",
            AttributeInputTypeId = 1,
            IsNecessary = true,
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            CreatedDate = DateTime.Now,
        }
        );
    }
}
