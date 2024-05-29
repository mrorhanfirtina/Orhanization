using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ProductEntitySeed;

public class ProductCategoryListSeed : IEntityTypeConfiguration<ProductCategoryList>
{
    public void Configure(EntityTypeBuilder<ProductCategoryList> builder)
    {
        builder.HasData(
                new ProductCategoryList
                {
                    Id = 1,
                    Code = "SVB",
                    Description = "Stock Value Based",
                    Priority = 1,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    CreatedDate = DateTime.Now,
                },
                new ProductCategoryList
                {
                    Id = 2,
                    Code = "SLV",
                    Description = "Sales Velocity Based",
                    Priority = 2,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    CreatedDate = DateTime.Now,
                },
                new ProductCategoryList
                {
                    Id = 3,
                    Code = "PMB",
                    Description = "Profit Margin Based",
                    Priority = 3,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    CreatedDate = DateTime.Now,
                }

            );
    }
}
