using Monstersoft.VennWms.Main.Application.Repositories.SerialRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.SerialRepositories;

public class SerialHierarchyRepository : EFRepositoryBase<SerialHierarchy, Guid, BaseDbContext>, ISerialHierarchyRepository { public SerialHierarchyRepository(BaseDbContext context) : base(context) { } }

