using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ReturnEntitySeed;

public class ReturnSeed : IEntityTypeConfiguration<Return>
{
    public void Configure(EntityTypeBuilder<Return> builder)
    {
        builder.HasData(
        new Return
        {
            Id = Guid.Parse("a7bcad1b-4411-4f8d-850c-78466ef24655"),
            Code = "CR20240101",
            CustomerId = Guid.Parse("1E36CA18-687B-49A6-9E76-1632136ECD1B"),
            ReturnTypeId = Guid.Parse("fbd90814-b13b-4a84-8e27-a319f4b023ea"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            DepositorId = Guid.Parse("202D64F3-4474-4B55-B30D-61C430799EFA"),
            InputDate = DateTime.Now,
            CreatedDate = DateTime.Now,
            StatusId = 1
        }            
        );  
    }
}
