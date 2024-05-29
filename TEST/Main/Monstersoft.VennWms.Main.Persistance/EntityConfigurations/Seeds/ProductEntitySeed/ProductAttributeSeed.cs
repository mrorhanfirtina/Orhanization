using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ProductEntitySeed;

public class ProductAttributeSeed : IEntityTypeConfiguration<ProductAttribute>
{
    public void Configure(EntityTypeBuilder<ProductAttribute> builder)
    {
        builder.HasData(
                new ProductAttribute
                {
                    Id = Guid.Parse("b515831f-3993-47dd-afa4-333b00c6f4b7"),
                    Code = "SP",
                    Description = "Selling price",
                    AttributeInputTypeId = 3,
                    IsNecessary = false,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    CreatedDate = DateTime.Now,
                },

                new ProductAttribute
                {
                    Id = Guid.Parse("bf9dc74f-ceb2-43be-b83e-7cdf3fe1ced3"),
                    Code = "SE",
                    Description = "Season",
                    AttributeInputTypeId = 1,
                    IsNecessary = false,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    CreatedDate = DateTime.Now,
                },

                new ProductAttribute
                {
                    Id = Guid.Parse("c8628509-6a62-49f3-b6a6-8ac9e3fd3c13"),
                    Code = "DY",
                    Description = "Design year",
                    AttributeInputTypeId = 4,
                    IsNecessary = false,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    CreatedDate = DateTime.Now,
                },

                new ProductAttribute
                {
                    Id = Guid.Parse("05c91892-1056-432a-bd8f-9e83db4b2227"),
                    Code = "MD",
                    Description = "Model",
                    AttributeInputTypeId = 1,
                    IsNecessary = false,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    CreatedDate = DateTime.Now,
                },

                new ProductAttribute
                {
                    Id = Guid.Parse("a1fdc4c7-4da2-496c-bb89-c969619d58b3"),
                    Code = "PC",
                    Description = "Product category",
                    AttributeInputTypeId = 1,
                    IsNecessary = true,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    CreatedDate = DateTime.Now,
                },

                new ProductAttribute
                {
                    Id = Guid.Parse("39e6e6c2-5d91-40a8-923a-64500f4b14d7"),
                    Code = "CRP",
                    Description = "Consumer-ready products",
                    AttributeInputTypeId = 2,
                    IsNecessary = true,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    CreatedDate = DateTime.Now,
                }

            );
    }
}
