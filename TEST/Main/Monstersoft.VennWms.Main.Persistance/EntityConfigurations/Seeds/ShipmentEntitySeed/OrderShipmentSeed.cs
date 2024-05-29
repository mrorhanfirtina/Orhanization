using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ShipmentEntitySeed;

public class OrderShipmentSeed : IEntityTypeConfiguration<OrderShipment>
{
    public void Configure(EntityTypeBuilder<OrderShipment> builder)
    {
        builder.HasData(
        new OrderShipment
        {
            Id = Guid.Parse("733ec453-60d8-403c-a522-90528ac11ca6"),
            Code = "SH0000001",
            OrderId = Guid.Parse("D6955E86-F0D1-447B-97C7-1460DEC08721"),
            ShipmentId = Guid.Parse("94b82659-a683-4965-accc-bc5d5aaf713b"),
            DepositorCompanyId = Guid.Parse("DD4D5460-8146-4E62-AC19-A74D89955DD7"),
            ProgressStatusId = 1,
            LastMoveDate = DateTime.Now,
            CreatedDate = DateTime.Now,
        }
        );  
    }
}
