using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;

public interface IProductAttributeValueRepository : IAsyncRepository<ProductAttributeValue, Guid>, IRepository<ProductAttributeValue, Guid> { }

