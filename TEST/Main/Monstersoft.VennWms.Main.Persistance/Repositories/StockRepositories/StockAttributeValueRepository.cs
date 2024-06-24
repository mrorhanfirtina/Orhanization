﻿using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.StockRepositories;

public class StockAttributeValueRepository : EFRepositoryBase<StockAttributeValue, Guid, BaseDbContext>, IStockAttributeValueRepository { public StockAttributeValueRepository(BaseDbContext context) : base(context) { } }
