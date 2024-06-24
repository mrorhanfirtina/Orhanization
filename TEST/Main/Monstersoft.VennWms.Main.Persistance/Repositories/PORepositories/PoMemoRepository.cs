using Monstersoft.VennWms.Main.Application.Repositories.PORepositories;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.PORepositories;

public class PoMemoRepository : EFRepositoryBase<PoMemo, Guid, BaseDbContext>, IPoMemoRepository { public PoMemoRepository(BaseDbContext context) : base(context) { } }
