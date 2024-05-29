using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.CommonEntitySeed;

public class AbcCategoryListSeed : IEntityTypeConfiguration<AbcCategoryList>
{
    public void Configure(EntityTypeBuilder<AbcCategoryList> builder)
    {
        builder.HasData(
            new AbcCategoryList
            {
                Id = 1,
                Code = "A",
                Description = "Category A",
                Priority = 1,
                CreatedDate = DateTime.Now
            },
            new AbcCategoryList
            {
                Id = 2,
                Code = "B",
                Description = "Category B",
                Priority = 2,
                CreatedDate = DateTime.Now
            },
            new AbcCategoryList
            {
                Id = 3,
                Code = "C",
                Description = "Category C",
                Priority = 3,
                CreatedDate = DateTime.Now
            }
        );
    }
}
