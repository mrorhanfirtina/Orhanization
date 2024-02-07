using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.TaskRepositories;

public class TaskStockRepository : EFRepositoryBase<TaskStock, Guid, BaseDbContext>, ITaskStockRepository { public TaskStockRepository(BaseDbContext context) : base(context) { } }
