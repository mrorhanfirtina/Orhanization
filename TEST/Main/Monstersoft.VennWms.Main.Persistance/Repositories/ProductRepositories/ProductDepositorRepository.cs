using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.ProductRepositories;

public class ProductDepositorRepository : EFRepositoryBase<ProductDepositor, Guid, BaseDbContext>, IProductDepositorRepository { public ProductDepositorRepository(BaseDbContext context) : base(context) { } }

