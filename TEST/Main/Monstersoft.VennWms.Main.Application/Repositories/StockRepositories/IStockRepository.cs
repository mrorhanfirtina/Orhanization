﻿using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;

public interface IStockRepository : IAsyncRepository<Stock, Guid>, IRepository<Stock, Guid> { }

