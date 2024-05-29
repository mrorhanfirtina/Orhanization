using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.PurchaseOrderEntitySeed;

public class PoTypeSeed : IEntityTypeConfiguration<PoType>
{
    public void Configure(EntityTypeBuilder<PoType> builder)
    {
        builder.HasData(
            new PoType
            {
                Id = Guid.Parse("9c169eb5-f090-4a3e-bedc-d94653e74cab"),
                Code = "P",
                Description = "GC Purchase Order",
                IsCodeGenerate = true,
                Format = "000000",
                Counter = 1,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
            },
            new PoType
            {
                Id = Guid.Parse("46ec506e-b979-4261-8227-056aebab69f2"),
                Code = "P0",
                Description = "Purchase Order",
                IsCodeGenerate = false,
                Format = "000000",
                Counter = 1,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
            }

            );
    }
}
