using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.OrderEntitySeed;

public class OrderItemStockAttrValueSeed : IEntityTypeConfiguration<OrderItemStockAttrValue>
{
    public void Configure(EntityTypeBuilder<OrderItemStockAttrValue> builder)
    {
        builder.HasData(
            new OrderItemStockAttrValue
            {
                Id= Guid.Parse("493c415f-cef9-441f-aa2f-069774dcb681"),
                OrderItemId = Guid.Parse("9f1ee1c8-3214-4c25-984c-131eadcb91e5"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                Value = "AMBAR3",
                CreatedDate = DateTime.Now,
            }
        );
    }
}
