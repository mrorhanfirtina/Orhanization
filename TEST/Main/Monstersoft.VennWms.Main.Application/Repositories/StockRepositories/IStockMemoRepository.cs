using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;

public interface IStockMemoRepository : IAsyncRepository<StockMemo, Guid>, IRepository<StockMemo, Guid> { }

