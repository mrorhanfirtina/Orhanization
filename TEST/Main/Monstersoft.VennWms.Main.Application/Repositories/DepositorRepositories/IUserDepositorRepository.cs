using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;

public interface IUserDepositorRepository : IAsyncRepository<UserDepositor, Guid>, IRepository<UserDepositor, Guid> { }
