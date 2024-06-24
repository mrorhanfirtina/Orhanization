using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ReturnEntitySeed;

public class ReturnItemMemoSeed : IEntityTypeConfiguration<ReturnItemMemo>
{
    public void Configure(EntityTypeBuilder<ReturnItemMemo> builder)
    {
        builder.HasData(
        new ReturnItemMemo
        {
            Id = Guid.Parse("e0bb8898-06fd-41a7-a443-7901541bb4c5"),
            ReturnItemId = Guid.Parse("66e3d6b9-c342-45be-8384-ab3e68a1d51f"),
            Description = "Test Memo 1",
            Text = "Test Memo 1 text",
            InputDate = DateTime.Now,
            CreatedDate = DateTime.Now,
        }
        );
    }
}
