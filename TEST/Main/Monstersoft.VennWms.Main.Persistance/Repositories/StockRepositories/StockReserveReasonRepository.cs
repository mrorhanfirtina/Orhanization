using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.StockRepositories;

public class StockReserveReasonRepository : EFRepositoryBase<StockReserveReason, Guid, BaseDbContext>, IStockReserveReasonRepository { public StockReserveReasonRepository(BaseDbContext context) : base(context) { } }
