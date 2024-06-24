using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.ProductRepositories;

public class ProductCategoryListRepository : EFRepositoryBase<ProductCategoryList, int, BaseDbContext>, IProductCategoryListRepository
{
    public ProductCategoryListRepository(BaseDbContext context) : base(context) { }
}
