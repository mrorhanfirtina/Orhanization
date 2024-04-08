using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;

public interface IStockPackTypeRepository : IAsyncRepository<StockPackType, Guid>, IRepository<StockPackType, Guid> { }

