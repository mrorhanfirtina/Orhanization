using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ShipmentEntitySeed;

public class ShipmentSeed : IEntityTypeConfiguration<Shipment>
{
    public void Configure(EntityTypeBuilder<Shipment> builder)
    {
        builder.HasData(
        new Shipment
        {
            Id = Guid.Parse("94b82659-a683-4965-accc-bc5d5aaf713b"),
            Code = "SH0000001",
            ShipmentTypeId = Guid.Parse("a02576d0-2f77-486b-a330-76c70cd4e330"),
            DistributorId = Guid.Parse("D84B5F55-35B6-48DC-8075-E7727ACA51C0"),
            BranchId = Guid.Parse("E9A3E8DD-2CDC-4782-80D9-B001D2DDE087"),
            DepositorId = Guid.Parse("202D64F3-4474-4B55-B30D-61C430799EFA"),
            DepositorCompanyId = Guid.Parse("DD4D5460-8146-4E62-AC19-A74D89955DD7"),
            CreatedDate = DateTime.Now,
            InputDate = DateTime.Now,
            ExpectedDate = DateTime.Now,
        }

        );
    }
}
