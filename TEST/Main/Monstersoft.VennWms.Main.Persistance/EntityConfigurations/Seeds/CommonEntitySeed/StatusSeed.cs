using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.CommonEntitySeed;

public class StatusSeed : IEntityTypeConfiguration<Status>
{
    public void Configure(EntityTypeBuilder<Status> builder)
    {
        builder.HasData(
                new Status { Id = 1, Code = "01", Description = "Pending", CreatedDate = DateTime.Now },
                new Status { Id = 2, Code = "02", Description = "Executing", CreatedDate = DateTime.Now },
                new Status { Id = 3, Code = "03", Description = "Completed", CreatedDate = DateTime.Now },
                new Status { Id = 4, Code = "04", Description = "Cancelled", CreatedDate = DateTime.Now }
            );
    }
}
