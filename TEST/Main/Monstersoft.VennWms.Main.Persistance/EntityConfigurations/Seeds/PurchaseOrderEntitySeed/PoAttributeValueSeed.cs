using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.PurchaseOrderEntitySeed;

public class PoAttributeValueSeed : IEntityTypeConfiguration<PoAttributeValue>
{
    public void Configure(EntityTypeBuilder<PoAttributeValue> builder)
    {
        builder.HasData(
            new PoAttributeValue
            {
                Id = Guid.Parse("b99a8cc4-d141-4722-b82d-69a30242bb1a"),
                PoAttributeId = Guid.Parse("bdfd9b06-2b2c-446a-b74f-28d1972e1bbd"),
                PurchaseOrderId = Guid.Parse("20be69f3-1c3d-4916-8499-f7d6deca1bfb"),
                Value = "PO00000466116385",
                CreatedDate = DateTime.Now,
            },
            new PoAttributeValue
            {
                Id = Guid.Parse("3fe28051-d7a7-4058-abf1-d5f1303fd0cd"),
                PoAttributeId = Guid.Parse("bdfd9b06-2b2c-446a-b74f-28d1972e1bbd"),
                PurchaseOrderId = Guid.Parse("61789239-097b-40f8-af15-3dcd8c778314"),
                Value = "PO00000196133977",
                CreatedDate = DateTime.Now,
            },
            new PoAttributeValue
            {
                Id = Guid.Parse("5b425f3c-0e07-4bd2-a81c-3643e8736519"),
                PoAttributeId = Guid.Parse("bdfd9b06-2b2c-446a-b74f-28d1972e1bbd"),
                PurchaseOrderId = Guid.Parse("4814a111-d13f-41b5-a1e9-f46ad15f7e1a"),
                Value = "PO00000152785489",
                CreatedDate = DateTime.Now,
            },
            new PoAttributeValue
            {
                Id = Guid.Parse("8377591f-9d3e-4a28-9e01-bad2f0484a12"),
                PoAttributeId = Guid.Parse("bdfd9b06-2b2c-446a-b74f-28d1972e1bbd"),
                PurchaseOrderId = Guid.Parse("13b2fb88-addd-490e-b38a-9f3e3b1f840e"),
                Value = "PO00000433236157",
                CreatedDate = DateTime.Now,
            },
            new PoAttributeValue
            {
                Id = Guid.Parse("c2e1997f-2966-41ab-a2e4-5b978db029aa"),
                PoAttributeId = Guid.Parse("bdfd9b06-2b2c-446a-b74f-28d1972e1bbd"),
                PurchaseOrderId = Guid.Parse("f2485ca7-051f-4a4c-b6cd-38144a434e3e"),
                Value = "PO00000291085201",
                CreatedDate = DateTime.Now,
            }

            );
    }
}
