using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.StockEntitySeed;

public class StockContainerSeed : IEntityTypeConfiguration<StockContainer>
{
    public void Configure(EntityTypeBuilder<StockContainer> builder)
    {
        builder.HasData(
        new StockContainer
        {
            Id = Guid.Parse("02d851ee-5883-431d-9366-f0d3f8b38f88"),
            ContainerUnitId = 2,
            Sscc = "386997451000007807",
            CreatedDate = DateTime.Now,
        },
        new StockContainer
        {
            Id = Guid.Parse("02fbffcb-f4ee-4dd6-a051-6b841b7d1ba5"),
            ContainerUnitId = 2,
            Sscc = "386997451000002987",
            CreatedDate = DateTime.Now,
        },
        new StockContainer
        {
            Id = Guid.Parse("1f1f09a8-fe1b-48f7-9e50-19bfd47b5042"),
            ContainerUnitId = 2,
            Sscc = "386997451000003609",
            CreatedDate = DateTime.Now,
        },
        new StockContainer
        {
            Id = Guid.Parse("0467cbab-2521-4613-99b4-d15b971b6e06"),
            ContainerUnitId = 7,
            Sscc = "386997451000002965",
            CreatedDate = DateTime.Now,
        },
        new StockContainer
        {
            Id = Guid.Parse("19ab1a97-bccf-48f0-8dda-44d5b22241d6"),
            ContainerUnitId = 7,
            Sscc = "386997451000003614",
            CreatedDate = DateTime.Now,
        },
        new StockContainer
        {
            Id = Guid.Parse("1d5085db-e2a8-484d-9a28-b209571c4d15"),
            ContainerUnitId = 7,
            Sscc = "386997451000000052",
            CreatedDate = DateTime.Now,
        },
        new StockContainer
        {
            Id = Guid.Parse("20de0087-5399-44dd-9582-b4b071cde019"),
            ContainerUnitId = 7,
            Sscc = "386997451000004927",
            CreatedDate = DateTime.Now,
        }
        );
    }
}
