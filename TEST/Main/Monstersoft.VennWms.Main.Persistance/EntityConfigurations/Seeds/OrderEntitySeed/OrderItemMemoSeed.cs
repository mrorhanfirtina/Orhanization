using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.OrderEntitySeed;

public class OrderItemMemoSeed : IEntityTypeConfiguration<OrderItemMemo>
{
    public void Configure(EntityTypeBuilder<OrderItemMemo> builder)
    {
        builder.HasData(
        new OrderItemMemo
        {
            Id = Guid.Parse("f3b3b3b3-1b3b-4b3b-8b3b-3b3b3b3b3b3b"),
            OrderItemId = Guid.Parse("de95bd51-501e-489f-b18d-34a052a8d145"),
            Description = "This is a memo",
            Text = "This is a memo text",
            InputDate = DateTime.Now,
            CreatedDate = DateTime.Now,
        }

        );
    }
}
