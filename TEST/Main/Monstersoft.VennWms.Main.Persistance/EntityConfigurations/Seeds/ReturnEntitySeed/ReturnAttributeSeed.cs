using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ReturnEntitySeed;

public class ReturnAttributeSeed : IEntityTypeConfiguration<ReturnAttribute>
{
    public void Configure(EntityTypeBuilder<ReturnAttribute> builder)
    {
        builder.HasData(
        new ReturnAttribute
        {
            Id = Guid.Parse("e68dcb0c-772f-4eb7-97db-bec853bf386b"),
            Code = "RR",
            Description = "Return Reason",
            AttributeInputTypeId = 1,
            IsNecessary = false,
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
        }

        );
    }
}
