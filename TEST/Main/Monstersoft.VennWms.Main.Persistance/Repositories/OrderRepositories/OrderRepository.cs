using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.OrderRepositories;

public class OrderRepository : EFRepositoryBase<Order, Guid, BaseDbContext>, IOrderRepository { public OrderRepository(BaseDbContext context) : base(context) { } }
