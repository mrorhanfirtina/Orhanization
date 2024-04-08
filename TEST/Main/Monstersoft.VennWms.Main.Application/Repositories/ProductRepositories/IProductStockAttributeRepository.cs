using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;

public interface IProductStockAttributeRepository : IAsyncRepository<ProductStockAttribute, Guid>, IRepository<ProductStockAttribute, Guid> { }
