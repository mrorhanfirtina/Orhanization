using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ReceiptEntitySeed;

public class ReceiptItemMemoSeed : IEntityTypeConfiguration<ReceiptItemMemo>
{
    public void Configure(EntityTypeBuilder<ReceiptItemMemo> builder)
    {
        builder.HasData(
        new ReceiptItemMemo
        {
            Id = Guid.Parse("7f1c3c83-85ea-4e1c-87ff-9c96dbb24404"),
            ReceiptItemId = Guid.Parse("53ffed4d-a02e-453d-aa5d-6a8f459458b9"),
            Description = "Memo 1",
            Text = "Memo 1 Text",
            InputDate = DateTime.Now,
            CreatedDate = DateTime.Now,
        },
        new ReceiptItemMemo
        {
            Id = Guid.Parse("ee3fff08-434a-426b-ae42-3a3b01ab4b2c"),
            ReceiptItemId = Guid.Parse("53ffed4d-a02e-453d-aa5d-6a8f459458b9"),
            Description = "Memo 2",
            Text = "Memo 2 Text",
            InputDate = DateTime.Now,
            CreatedDate = DateTime.Now,
        }
        );
    }
}
