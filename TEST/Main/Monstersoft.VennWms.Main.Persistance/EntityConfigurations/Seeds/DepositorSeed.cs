using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds;

public class DepositorSeed : IEntityTypeConfiguration<Depositor>
{
    public void Configure(EntityTypeBuilder<Depositor> builder)
    {
        builder.HasData(
                new Depositor
                {
                    Id = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                    Code = "MAIN",
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    CreatedDate = DateTime.Now,
                }
            );
    }
}
