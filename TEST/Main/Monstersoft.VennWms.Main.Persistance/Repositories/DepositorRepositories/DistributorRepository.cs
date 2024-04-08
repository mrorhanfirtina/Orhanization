using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.DepositorRepositories;

public class DistributorRepository : EFRepositoryBase<Distributor, Guid, BaseDbContext>, IDistributorRepository { public DistributorRepository(BaseDbContext context) : base(context) { } }
