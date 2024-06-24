using Monstersoft.VennWms.Main.Application.Repositories.LoggingRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.LoggingRepositories;

public class LogStockReserveReasonRepository : EFRepositoryBase<LogStockReserveReason, Guid, BaseDbContext>, ILogStockReserveReasonRepository { public LogStockReserveReasonRepository(BaseDbContext context) : base(context) { } }
