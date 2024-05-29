using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.OrderEntitySeed;

public class OrderAttributeSeed : IEntityTypeConfiguration<OrderAttribute>
{
    public void Configure(EntityTypeBuilder<OrderAttribute> builder)
    {
        builder.HasData(
        new OrderAttribute
        {
            Id = Guid.Parse("ace1c325-d3d7-4556-a232-052f595e969b"),
            Code = "O001",
            Description = "IsExported",
            AttributeInputTypeId = 2,
            IsNecessary = true,
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            CreatedDate = DateTime.Now,
        }
        );
    }
}
