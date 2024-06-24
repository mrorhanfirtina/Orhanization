using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.ProductRepositories;

public class ItemPackTypeRepository : EFRepositoryBase<ItemPackType, Guid, BaseDbContext>, IItemPackTypeRepository { public ItemPackTypeRepository(BaseDbContext context) : base(context) { } }