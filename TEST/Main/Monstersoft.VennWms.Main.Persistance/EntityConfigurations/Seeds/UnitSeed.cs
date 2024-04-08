using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds;

public class UnitSeed : IEntityTypeConfiguration<Unit>
{
    public void Configure(EntityTypeBuilder<Unit> builder)
    {
        builder.HasData(
                new Unit { Id = 1, Code = "EA", Description = "Adet", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
                new Unit { Id = 2, Code = "m", Description = "Meter", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
                new Unit { Id = 3, Code = "desi", Description = "Desi", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") }
            );
    }
}
