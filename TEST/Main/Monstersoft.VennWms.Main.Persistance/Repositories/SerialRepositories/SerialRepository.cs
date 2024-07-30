using Monstersoft.VennWms.Main.Application.Repositories.SerialRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.SerialRepositories;

public class SerialRepository : EFRepositoryBase<Serial, Guid, BaseDbContext>, ISerialRepository { public SerialRepository(BaseDbContext context) : base(context) { } }

