using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ShipmentEntitySeed;

public class ShipmentTypeSeed : IEntityTypeConfiguration<ShipmentType>
{
    public void Configure(EntityTypeBuilder<ShipmentType> builder)
    {
        builder.HasData(
        new ShipmentType
        {
            Id = Guid.Parse("a02576d0-2f77-486b-a330-76c70cd4e330"),
            Code = "SHT01",
            Description = "Standard Shipment",
            IsCodeGenerate = true,
            Format = "SH{0000000}",
            Counter = 2,
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            CreatedDate = DateTime.Now,
        }
        );
    }
}
