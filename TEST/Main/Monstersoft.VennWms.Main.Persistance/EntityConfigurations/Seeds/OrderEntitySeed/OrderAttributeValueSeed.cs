using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.OrderEntitySeed;

public class OrderAttributeValueSeed : IEntityTypeConfiguration<OrderAttributeValue>
{
    public void Configure(EntityTypeBuilder<OrderAttributeValue> builder)
    {
        builder.HasData(
            new OrderAttributeValue
            {
                Id = Guid.Parse("89421f3c-beca-40ae-9158-795490cd2856"),
                OrderAttributeId = Guid.Parse("ace1c325-d3d7-4556-a232-052f595e969b"),
                OrderId = Guid.Parse("d6955e86-f0d1-447b-97c7-1460dec08721"),
                Value = "0",
                CreatedDate = DateTime.Now,
            }
        );
    }
}
