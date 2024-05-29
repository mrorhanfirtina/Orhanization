using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.OrderEntitySeed;

public class OrderSeed : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasData(
            new Order
            {
                Id = Guid.Parse("d6955e86-f0d1-447b-97c7-1460dec08721"),
                OrderTypeId = Guid.Parse("5608f62d-7947-436f-a9d8-40cf01c12ade"),
                Code = "SO000001",
                CustomerId = Guid.Parse("15129AB9-882D-456B-AF1A-22668CE33A22"),
                ReceiverId = Guid.Parse("EAD53E6F-578C-4577-9E81-00C4E479CD1D"),
                StatusId = 1,
                DepositorId = Guid.Parse("202D64F3-4474-4B55-B30D-61C430799EFA"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                InputDate = DateTime.Now,
                CreatedDate = DateTime.Now,
            }

        );
    }
}
