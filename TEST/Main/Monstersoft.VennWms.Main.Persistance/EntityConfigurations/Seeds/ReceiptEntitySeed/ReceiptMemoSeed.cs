using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ReceiptEntitySeed;

public class ReceiptMemoSeed : IEntityTypeConfiguration<ReceiptMemo>
{
    public void Configure(EntityTypeBuilder<ReceiptMemo> builder)
    {
        builder.HasData(
        new ReceiptMemo
        {
            Id = Guid.Parse("abf1f682-feae-49f4-b5a3-342360c8a1d8"),
            ReceiptId = Guid.Parse("4d400f84-652e-471f-9fdd-b1d7630855f1"),
            Description = "This is a test receipt memo",
            Text = "This is a test receipt memo",
            InputDate = DateTime.Now,
            CreatedDate = DateTime.Now,
        }

        );
    }
}
