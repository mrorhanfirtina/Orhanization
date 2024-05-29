using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ReturnEntitySeed;

public class ReturnTypeSeed : IEntityTypeConfiguration<ReturnType>
{
    public void Configure(EntityTypeBuilder<ReturnType> builder)
    {
        builder.HasData(
        new ReturnType
        {
            Id = Guid.Parse("fbd90814-b13b-4a84-8e27-a319f4b023ea"),
            Code = "CR",
            Description = "Customer Return",
            Format = "CR-{000000}",
            IsCodeGenerate = false,
            Counter = 1,
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            CreatedDate = DateTime.Now,
        }
        );
    }
}
