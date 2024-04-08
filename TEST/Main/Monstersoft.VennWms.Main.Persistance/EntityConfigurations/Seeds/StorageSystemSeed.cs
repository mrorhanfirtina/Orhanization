using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds;

public class StorageSystemSeed : IEntityTypeConfiguration<StorageSystem>
{
    public void Configure(EntityTypeBuilder<StorageSystem> builder)
    {
        builder.HasData(
            new StorageSystem
            {
                Id = Guid.Parse("861615e9-ec51-44f2-91dc-7a30fa477896"),
                BuildingId = Guid.Parse("6b94bdfe-4158-4e98-816e-a3422816b2a3"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                Code = "RAMP",
                Description = "Ramp Area",
                CreatedDate = DateTime.Now
            }
        );
    }
}
