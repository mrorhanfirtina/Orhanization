using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.OrderEntitySeed;

public class OrderTypeSeed : IEntityTypeConfiguration<OrderType>
{
    public void Configure(EntityTypeBuilder<OrderType> builder)
    {
        builder.HasData(
        new OrderType
        {
            Id = Guid.Parse("5608f62d-7947-436f-a9d8-40cf01c12ade"),
            Code = "SALES",
            Description = "Sales Order",
            IsCodeGenerate = true,
            Format = "SO{000000}",
            Counter = 2,
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            CreatedDate = DateTime.Now,
        }

        );
    }
}
