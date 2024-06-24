using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ReturnEntitySeed;

public class ReturnItmStockAttrValueSeed : IEntityTypeConfiguration<ReturnItmStockAttrValue>
{
    public void Configure(EntityTypeBuilder<ReturnItmStockAttrValue> builder)
    {
        builder.HasData(
        new ReturnItmStockAttrValue
        {
            Id = Guid.Parse("54e26c7e-321f-46ec-8927-b27c424b6b83"),
            ReturnItemId = Guid.Parse("66e3d6b9-c342-45be-8384-ab3e68a1d51f"),
            StockAttributeId = Guid.Parse("821eaf46-cd9b-4daa-bf16-be5025687da1"),
            Value = "125600010",
            CreatedDate = DateTime.Now,
        }  
        );
    }
}
