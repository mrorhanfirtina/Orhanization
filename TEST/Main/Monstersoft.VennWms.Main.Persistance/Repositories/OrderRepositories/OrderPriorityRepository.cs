﻿using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.OrderRepositories;

public class OrderPriorityRepository : EFRepositoryBase<OrderPriority, Guid, BaseDbContext>, IOrderPriorityRepository
{
    public OrderPriorityRepository(BaseDbContext context) : base(context) { }
}