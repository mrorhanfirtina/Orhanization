using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ShipmentEntitySeed;

public class ShipmentMemoSeed : IEntityTypeConfiguration<ShipmentMemo>
{
    public void Configure(EntityTypeBuilder<ShipmentMemo> builder)
    {
        builder.HasData(
        new ShipmentMemo
        {
            Id = Guid.Parse("43af288a-7537-499a-bf6e-f1ce11a861b1"),
            ShipmentId = Guid.Parse("94b82659-a683-4965-accc-bc5d5aaf713b"),
            Description = "This is a memo",
            Text = "This is a test shipment memo",
            InputDate = DateTime.Now,
            CreatedDate = DateTime.Now,
        }

        );
    }
}
