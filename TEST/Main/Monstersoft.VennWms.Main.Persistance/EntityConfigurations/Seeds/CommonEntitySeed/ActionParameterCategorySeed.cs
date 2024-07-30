using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.CommonEntitySeed;

public class ActionParameterCategorySeed : IEntityTypeConfiguration<ActionParameterCategory>
{
    public void Configure(EntityTypeBuilder<ActionParameterCategory> builder)
    {
        builder.HasData(
                       new ActionParameterCategory
                       {
                           Id = 1,
                           Name = "General Parameters",
                           CreatedDate = DateTime.Now
                       },
                       new ActionParameterCategory
                       {
                           Id = 2,
                           Name = "DepositorCompany Parameters",
                           CreatedDate = DateTime.Now
                       },
                       new ActionParameterCategory
                       {
                           Id = 3,
                           Name = "Depositor Parameters",
                           CreatedDate = DateTime.Now
                       },
                       new ActionParameterCategory
                       {
                           Id = 4,
                           Name = "Receipt Parameters",
                           CreatedDate = DateTime.Now
                       },
                       new ActionParameterCategory
                       {
                           Id = 5,
                           Name = "Return Parameters",
                           CreatedDate = DateTime.Now
                       },
                       new ActionParameterCategory
                       {
                           Id = 6,
                           Name = "Relocate Parameters",
                           CreatedDate = DateTime.Now
                       },
                       new ActionParameterCategory
                       {
                           Id = 7,
                           Name = "StockChange Parameters",
                           CreatedDate = DateTime.Now
                       },
                       new ActionParameterCategory
                       {
                           Id = 8,
                           Name = "Picking Parameters",
                           CreatedDate = DateTime.Now
                       },
                       new ActionParameterCategory
                       {
                           Id = 9,
                           Name = "Loading Parameters",
                           CreatedDate = DateTime.Now
                       }
                       );
    }
}
