using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.DepositorRepositories;

public class ReceiverRepository : EFRepositoryBase<Receiver, Guid, BaseDbContext>, IReceiverRepository { public ReceiverRepository(BaseDbContext context) : base(context) { } }
