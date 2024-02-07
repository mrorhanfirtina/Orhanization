using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;

public interface IStockUnsuitReasonRepository : IAsyncRepository<StockUnsuitReason, Guid>, IRepository<StockUnsuitReason, Guid> { }

