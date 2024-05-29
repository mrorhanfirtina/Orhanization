using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ReturnEntitySeed;

public class ReturnAttributeValueSeed : IEntityTypeConfiguration<ReturnAttributeValue>
{
    public void Configure(EntityTypeBuilder<ReturnAttributeValue> builder)
    {
        builder.HasData(
        new ReturnAttributeValue
        {
            Id = Guid.Parse("147c421f-393d-4b3d-9e66-2094d0fd7803"),
            ReturnAttributeId = Guid.Parse("e68dcb0c-772f-4eb7-97db-bec853bf386b"),
            ReturnId = Guid.Parse("a7bcad1b-4411-4f8d-850c-78466ef24655"),
            Value = "Test Reason",
            CreatedDate = DateTime.Now,
        }
        );  
    }
}
