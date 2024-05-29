using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ShipmentEntitySeed;

public class OrderShipItemSeed : IEntityTypeConfiguration<OrderShipItem>
{
    public void Configure(EntityTypeBuilder<OrderShipItem> builder)
    {
        builder.HasData(
        new OrderShipItem
        {
            Id = Guid.Parse("42ba65e6-3495-4d0d-9d78-43805a782e3a"),
            OrderItemId = Guid.Parse("9F1EE1C8-3214-4C25-984C-131EADCB91E5"),
            OrderShipmentId = Guid.Parse("733ec453-60d8-403c-a522-90528ac11ca6"),
            Quantity = 1,
            ProgressStatusId = 1,
            CreatedDate = DateTime.Now,
        },
        new OrderShipItem
        {
            Id = Guid.Parse("3249ca6f-e1b0-45bc-8e80-340ccdd15b27"),
            OrderItemId = Guid.Parse("DE95BD51-501E-489F-B18D-34A052A8D145"),
            OrderShipmentId = Guid.Parse("733ec453-60d8-403c-a522-90528ac11ca6"),
            Quantity = 12,
            ProgressStatusId = 1,
            CreatedDate = DateTime.Now,
        }
        );  
    }
}
