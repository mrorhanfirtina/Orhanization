using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;

public interface IProductDepositorRepository : IAsyncRepository<ProductDepositor, Guid>, IRepository<ProductDepositor, Guid> { }

