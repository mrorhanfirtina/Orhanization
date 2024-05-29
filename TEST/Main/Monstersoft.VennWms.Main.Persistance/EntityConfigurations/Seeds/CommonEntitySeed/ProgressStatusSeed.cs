using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.CommonEntitySeed;

public class ProgressStatusSeed : IEntityTypeConfiguration<ProgressStatus>
{
    public void Configure(EntityTypeBuilder<ProgressStatus> builder)
    {
        builder.HasData(
                new ProgressStatus { Id = 1, Code = "01", Description = "Pending", CreatedDate = DateTime.Now },
                new ProgressStatus { Id = 2, Code = "02", Description = "ToPick", CreatedDate = DateTime.Now },
                new ProgressStatus { Id = 3, Code = "03", Description = "InPick", CreatedDate = DateTime.Now },
                new ProgressStatus { Id = 4, Code = "04", Description = "Picked", CreatedDate = DateTime.Now },
                new ProgressStatus { Id = 5, Code = "05", Description = "InSorting", CreatedDate = DateTime.Now },
                new ProgressStatus { Id = 6, Code = "06", Description = "Sorted", CreatedDate = DateTime.Now },
                new ProgressStatus { Id = 7, Code = "07", Description = "InPacking", CreatedDate = DateTime.Now },
                new ProgressStatus { Id = 8, Code = "08", Description = "Packed", CreatedDate = DateTime.Now },
                new ProgressStatus { Id = 9, Code = "09", Description = "InLoading", CreatedDate = DateTime.Now },
                new ProgressStatus { Id = 10, Code = "10", Description = "Completed", CreatedDate = DateTime.Now },
                new ProgressStatus { Id = 11, Code = "11", Description = "Cancelled", CreatedDate = DateTime.Now }
            );
    }
}
