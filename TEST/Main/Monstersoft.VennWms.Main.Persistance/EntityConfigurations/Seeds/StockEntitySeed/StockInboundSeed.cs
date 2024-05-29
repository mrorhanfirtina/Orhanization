using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.StockEntitySeed;

public class StockInboundSeed : IEntityTypeConfiguration<StockInbound>
{
    public void Configure(EntityTypeBuilder<StockInbound> builder)
    {
        builder.HasData(
            new StockInbound
            {
                Id = Guid.Parse("b722f4f5-9c57-4604-bf02-904f54dd8dd9"),
                StockId = Guid.Parse("471B8449-2BA3-4F41-A726-6D9206F40AC0"),
                CuItemUnitId = Guid.Parse("04752347-C443-4303-B576-C78027D8A0D9"),
                ReceiptId = Guid.Parse("019C1933-01FF-4433-A5B6-054AA5CB6F9B"),
                CuQuantity = 20m,
                CuQuantityFree = 20m,
                CreatedDate = DateTime.Now,
            }
        );
    }
}
