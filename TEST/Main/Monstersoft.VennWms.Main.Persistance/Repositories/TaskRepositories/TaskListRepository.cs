using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.TaskRepositories;

public class TaskListRepository : EFRepositoryBase<TaskList, Guid, BaseDbContext>, ITaskListRepository { public TaskListRepository(BaseDbContext context) : base(context) { } }
