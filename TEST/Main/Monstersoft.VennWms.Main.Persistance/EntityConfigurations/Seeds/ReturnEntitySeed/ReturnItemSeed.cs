using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ReturnEntitySeed;

public class ReturnItemSeed : IEntityTypeConfiguration<ReturnItem>
{
    public void Configure(EntityTypeBuilder<ReturnItem> builder)
    {
        builder.HasData(
        new ReturnItem
        {
            Id = Guid.Parse("66e3d6b9-c342-45be-8384-ab3e68a1d51f"),
            ReturnId = Guid.Parse("a7bcad1b-4411-4f8d-850c-78466ef24655"),
            ProductId = Guid.Parse("73A2EB51-7BF1-46EA-AEAA-08E771328BDD"),
            ItemUnitId = Guid.Parse("0222A6D5-371B-4E3B-A03B-AFFEB37B3D1E"),
            ExpectedQuantity = 36,
            ActualQuantity = 0,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        }
        );
    }
}
