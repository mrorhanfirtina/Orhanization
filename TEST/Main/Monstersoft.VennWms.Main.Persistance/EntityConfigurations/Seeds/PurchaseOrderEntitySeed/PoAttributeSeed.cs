using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.PurchaseOrderEntitySeed;

public class PoAttributeSeed : IEntityTypeConfiguration<PoAttribute>
{
    public void Configure(EntityTypeBuilder<PoAttribute> builder)
    {
        builder.HasData(
            new PoAttribute
            {
                Id = Guid.Parse("bdfd9b06-2b2c-446a-b74f-28d1972e1bbd"),
                AttributeInputTypeId = 1,
                Code = "PO-001",
                Description = "PO Number",
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            }
            );
    }
}
