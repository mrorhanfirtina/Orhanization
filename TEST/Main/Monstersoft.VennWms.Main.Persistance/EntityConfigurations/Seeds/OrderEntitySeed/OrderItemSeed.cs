using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.OrderEntitySeed;

public class OrderItemSeed : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.HasData(
            new OrderItem
            {
                Id = Guid.Parse("9f1ee1c8-3214-4c25-984c-131eadcb91e5"),
                OrderId = Guid.Parse("d6955e86-f0d1-447b-97c7-1460dec08721"),
                ProductId = Guid.Parse("00D22996-340A-46CC-8D64-2C103CB59ACF"),
                ItemUnitId = Guid.Parse("41DE7A60-8689-4F76-80DF-FFB67E6B8D45"),
                Quantity = 1,
                CreatedDate = DateTime.Now,
            },
            new OrderItem
            {
                Id = Guid.Parse("de95bd51-501e-489f-b18d-34a052a8d145"),
                OrderId = Guid.Parse("d6955e86-f0d1-447b-97c7-1460dec08721"),
                ProductId = Guid.Parse("73A2EB51-7BF1-46EA-AEAA-08E771328BDD"),
                ItemUnitId = Guid.Parse("39385DC7-A950-48D8-A2F2-D13AB91AEE10"),
                Quantity = 12,
                CreatedDate = DateTime.Now,
            }

        );
    }
}
