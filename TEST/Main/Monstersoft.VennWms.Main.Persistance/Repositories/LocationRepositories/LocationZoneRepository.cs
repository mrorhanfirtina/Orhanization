using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.LocationRepositories;

public class LocationZoneRepository : EFRepositoryBase<LocationZone, Guid, BaseDbContext>, ILocationZoneRepository { public LocationZoneRepository(BaseDbContext context) : base(context) { } }
