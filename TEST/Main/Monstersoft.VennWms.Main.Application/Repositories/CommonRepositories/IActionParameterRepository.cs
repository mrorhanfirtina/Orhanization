using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;

public interface IActionParameterRepository : IAsyncRepository<ActionParameter, int>, IRepository<ActionParameter, int> { }
