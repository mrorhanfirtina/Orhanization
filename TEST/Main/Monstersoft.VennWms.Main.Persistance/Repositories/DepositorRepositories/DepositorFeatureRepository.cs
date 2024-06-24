using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.DepositorRepositories;

public class DepositorFeatureRepository : EFRepositoryBase<DepositorFeature, Guid, BaseDbContext>, IDepositorFeatureRepository { public DepositorFeatureRepository(BaseDbContext context) : base(context) { } }
