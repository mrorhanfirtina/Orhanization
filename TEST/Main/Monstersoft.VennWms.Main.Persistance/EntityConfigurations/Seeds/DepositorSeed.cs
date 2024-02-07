using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds;

public class DepositorSeed : IEntityTypeConfiguration<Depositor>
{
    public void Configure(EntityTypeBuilder<Depositor> builder)
    {
        builder.HasData(
                new Depositor
                {
                    Id = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                    BuildingId = Guid.Parse("6b94bdfe-4158-4e98-816e-a3422816b2a3"),
                    Code = "MAIN",
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    CreatedDate = DateTime.Now,
                }
            );
    }
}
