using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.DepositorEntitySeed;

public class DepositorSeed : IEntityTypeConfiguration<Depositor>
{
    public void Configure(EntityTypeBuilder<Depositor> builder)
    {
        builder.HasData(
                new Depositor
                {
                    Id = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                    Code = "SEUR",
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    CompanyId = Guid.Parse("db4ba7ff-6c0a-4587-b740-2a002581eb2b"),
                    CreatedDate = DateTime.Now,
                },
                new Depositor
                {
                    Id = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                    Code = "SME",
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    CompanyId = Guid.Parse("c8d73b99-f35a-4a13-8f9d-0a35fcbba268"),
                    CreatedDate = DateTime.Now,
                }
            );
    }
}
