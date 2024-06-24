using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.StockEntitySeed;

public class StockAttributeSeed : IEntityTypeConfiguration<StockAttribute>
{
    public void Configure(EntityTypeBuilder<StockAttribute> builder)
    {
        builder.HasData(
            new StockAttribute
            {
                Id = Guid.Parse("424d8c1f-4501-4c38-a539-0cc877716563"),
                Code = "WH",
                Description = "Warehouse",
                AttributeInputTypeId = 1,
                IsNecessary = true,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
            },
            new StockAttribute
            {
                Id = Guid.Parse("eacd5b95-2e35-4b2e-8a9a-33da04bfdb76"),
                Code = "DM",
                Description = "IsDamaged",
                AttributeInputTypeId = 2,
                IsNecessary = true,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
            },
            new StockAttribute
            {
                Id = Guid.Parse("821eaf46-cd9b-4daa-bf16-be5025687da1"),
                Code = "LOT",
                Description = "Lot Number",
                AttributeInputTypeId = 3,
                IsNecessary = true,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
            },
            new StockAttribute
            {
                Id = Guid.Parse("7c2d8d28-90ef-458a-83a0-a1d80d0ac975"),
                Code = "PRD",
                Description = "Production Date",
                AttributeInputTypeId = 4,
                IsNecessary = true,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
            },
            new StockAttribute
            {
                Id = Guid.Parse("88f35bfa-2fe6-4db3-b40a-1d0c3563e1cc"),
                Code = "EXP",
                Description = "Expiration Date",
                AttributeInputTypeId = 4,
                IsNecessary = true,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
            }
        );
    }
}
