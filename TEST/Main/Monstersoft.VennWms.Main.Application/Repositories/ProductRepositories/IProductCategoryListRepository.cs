using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;

public interface IProductCategoryListRepository : IAsyncRepository<ProductCategoryList, int>, IRepository<ProductCategoryList, int> { }

