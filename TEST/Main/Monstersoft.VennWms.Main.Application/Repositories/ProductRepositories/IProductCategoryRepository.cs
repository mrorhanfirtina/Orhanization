using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;

public interface IProductCategoryRepository : IAsyncRepository<ProductCategory, Guid>, IRepository<ProductCategory, Guid> { }

