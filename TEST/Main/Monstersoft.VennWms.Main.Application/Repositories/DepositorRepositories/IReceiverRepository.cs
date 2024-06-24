using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;

public interface IReceiverRepository : IAsyncRepository<Receiver, Guid>, IRepository<Receiver, Guid> { }

