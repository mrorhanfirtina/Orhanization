using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ReceiptEntitySeed;

public class ReceiptAttributeSeed : IEntityTypeConfiguration<ReceiptAttribute>
{
    public void Configure(EntityTypeBuilder<ReceiptAttribute> builder)
    {
        builder.HasData(
        new ReceiptAttribute
        {
            Id = Guid.Parse("b04a7ee2-3a80-4bd3-b45f-6cd88fa5dfda"),
            Code = "RA001",
            Description = "Despatch Number",
            AttributeInputTypeId = 1,
            IsNecessary = true,
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            CreatedDate = DateTime.Now,
        }
        );
    }
}
