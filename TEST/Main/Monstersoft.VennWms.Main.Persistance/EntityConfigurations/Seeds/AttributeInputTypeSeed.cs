using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds;

public class AttributeInputTypeSeed : IEntityTypeConfiguration<AttributeInputType>
{
    public void Configure(EntityTypeBuilder<AttributeInputType> builder)
    {
        builder.HasData(
                new AttributeInputType { Id = 1, Description = "Text", CreatedDate = DateTime.Now },
                new AttributeInputType { Id = 2, Description = "Bool", CreatedDate = DateTime.Now },
                new AttributeInputType { Id = 3, Description = "Numeric", CreatedDate = DateTime.Now },
                new AttributeInputType { Id = 4, Description = "Date", CreatedDate = DateTime.Now },
                new AttributeInputType { Id = 5, Description = "DateTime", CreatedDate = DateTime.Now }
            );
    }
}
