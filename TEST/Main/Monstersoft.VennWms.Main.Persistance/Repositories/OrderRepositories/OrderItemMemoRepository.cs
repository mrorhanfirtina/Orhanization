using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.OrderRepositories;

public class OrderItemMemoRepository : EFRepositoryBase<OrderItemMemo, Guid, BaseDbContext>, IOrderItemMemoRepository { public OrderItemMemoRepository(BaseDbContext context) : base(context) { } }
