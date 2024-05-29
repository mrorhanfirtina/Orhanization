using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.StockEntitySeed;

public class StockMemoSeed : IEntityTypeConfiguration<StockMemo>
{
    public void Configure(EntityTypeBuilder<StockMemo> builder)
    {
        builder.HasData(
            new StockMemo
            {
                Id = Guid.Parse("adb5737b-a55e-412b-981a-780c19454084"),
                StockId = Guid.Parse("7792A3AC-494A-4A27-934E-99A8530C2640"),
                Description = "This is a test 1",
                Text = "This is a test memo for stock item 1",
                InputDate = DateTime.Now,
                CreatedDate = DateTime.Now,
            },
            new StockMemo
            {
                Id = Guid.Parse("ba40126b-6f9f-4ac3-95e7-0a2feb67b19f"),
                StockId = Guid.Parse("7792A3AC-494A-4A27-934E-99A8530C2640"),
                Description = "This is a test 2",
                Text = "This is a test memo for stock item 2",
                InputDate = DateTime.Now,
                CreatedDate = DateTime.Now,
            });
    }
}
