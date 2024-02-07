using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;

public interface IDisturbitorRepository : IAsyncRepository<Disturbitor, Guid>, IRepository<Disturbitor, Guid> { }

