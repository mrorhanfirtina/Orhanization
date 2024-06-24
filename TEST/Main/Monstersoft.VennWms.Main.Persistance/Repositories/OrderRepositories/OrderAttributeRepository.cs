using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.OrderRepositories;

public class OrderAttributeRepository : EFRepositoryBase<OrderAttribute, Guid, BaseDbContext>, IOrderAttributeRepository { public OrderAttributeRepository(BaseDbContext context) : base(context) { } }
