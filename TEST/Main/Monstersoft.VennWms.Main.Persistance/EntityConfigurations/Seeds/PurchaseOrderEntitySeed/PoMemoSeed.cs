using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.PurchaseOrderEntitySeed;

public class PoMemoSeed : IEntityTypeConfiguration<PoMemo>
{
    public void Configure(EntityTypeBuilder<PoMemo> builder)
    {
        builder.HasData(
            new PoMemo
            {
                Id = Guid.Parse("f2485ca7-051f-4a4c-b6cd-38144a434e3e"),
                PurchaseOrderId = Guid.Parse("61789239-097b-40f8-af15-3dcd8c778314"),
                Description = "Memo 2024",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi quis dolor elementum, bibendum leo id, iaculis libero.",
                InputDate = DateTime.Now,
                CreatedDate = DateTime.Now,
            }

        );
    }
}
