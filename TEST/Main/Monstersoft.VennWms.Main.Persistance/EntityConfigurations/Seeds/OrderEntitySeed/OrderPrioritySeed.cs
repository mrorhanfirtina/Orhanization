using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.OrderEntitySeed;

public class OrderPrioritySeed : IEntityTypeConfiguration<OrderPriority>
{
    public void Configure(EntityTypeBuilder<OrderPriority> builder)
    {
        builder.HasData(
            new OrderPriority
            {
                Id = Guid.Parse("b49617e9-b698-49c5-9f2d-ea71d31c19f8"),
                OrderId = Guid.Parse("d6955e86-f0d1-447b-97c7-1460dec08721"),
                PriorityId = 2,
                CreatedDate = DateTime.Now,
            }
        );
    }
}
