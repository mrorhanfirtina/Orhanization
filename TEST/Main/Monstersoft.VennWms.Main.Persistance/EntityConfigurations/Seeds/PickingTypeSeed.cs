using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds;

public class PickingTypeSeed : IEntityTypeConfiguration<PickingType>
{
    public void Configure(EntityTypeBuilder<PickingType> builder)
    {
        builder.HasData(
          new PickingType { Id = 1, Code = "1", Description = "Picking", CreatedDate = DateTime.Now },
          new PickingType { Id = 2, Code = "2", Description = "Stock", CreatedDate = DateTime.Now },
          new PickingType { Id = 3, Code = "3", Description = "No Picking", CreatedDate = DateTime.Now }
        );
    }
}
