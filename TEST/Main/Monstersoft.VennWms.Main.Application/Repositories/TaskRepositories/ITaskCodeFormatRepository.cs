using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;

public interface ITaskCodeFormatRepository : IAsyncRepository<TaskCodeFormat, Guid>, IRepository<TaskCodeFormat, Guid> { }

