using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.StockEntitySeed;

public class StockReserveReasonSeed : IEntityTypeConfiguration<StockReserveReason>
{
    public void Configure(EntityTypeBuilder<StockReserveReason> builder)
    {
        builder.HasData(
        new StockReserveReason
        {
            Id = Guid.Parse("579322af-36a9-47f5-a2d5-f18cc651f53b"),
            StockId = Guid.Parse("BF35AEC9-2510-419D-9A43-9959A5ABA873"),
            ReserveReasonId = Guid.Parse("79A54CAB-DED3-4DCD-85F8-79866D31F375"),
            CreatedDate = DateTime.Now,
        }
        );
    }
}
