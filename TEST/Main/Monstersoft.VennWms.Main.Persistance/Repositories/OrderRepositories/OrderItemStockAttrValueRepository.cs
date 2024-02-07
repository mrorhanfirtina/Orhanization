﻿using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.OrderRepositories;

public class OrderItemStockAttrValueRepository : EFRepositoryBase<OrderItemStockAttrValue, Guid, BaseDbContext>, IOrderItemStockAttrValueRepository { public OrderItemStockAttrValueRepository(BaseDbContext context) : base(context) { } }
