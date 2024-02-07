using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds;

public class UnitSeed : IEntityTypeConfiguration<Unit>
{
    public void Configure(EntityTypeBuilder<Unit> builder)
    {
        builder.HasData(
                new Unit { Id = 1, Code = "EA", Description = "Adet", CreatedDate = DateTime.Now, DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa") }
            );
    }
}
