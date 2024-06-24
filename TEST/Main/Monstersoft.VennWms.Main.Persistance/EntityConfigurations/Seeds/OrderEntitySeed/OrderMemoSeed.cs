using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.OrderEntitySeed;

public class OrderMemoSeed : IEntityTypeConfiguration<OrderMemo>
{
    public void Configure(EntityTypeBuilder<OrderMemo> builder)
    {
        builder.HasData(
            new OrderMemo
            {
                Id = Guid.Parse("b94d0a29-ec9a-4a41-b1b2-ba4da0a3c784"),
                OrderId = Guid.Parse("d6955e86-f0d1-447b-97c7-1460dec08721"),
                Description = "Test memo",
                Text = "This is a test memo",
                InputDate = DateTime.Now,
                CreatedDate = DateTime.Now,
            }

        );
    }
}
