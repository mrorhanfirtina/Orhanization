using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.ReturnRepositories;

public class ReturnItemMemoRepository : EFRepositoryBase<ReturnItemMemo, Guid, BaseDbContext>, IReturnItemMemoRepository { public ReturnItemMemoRepository(BaseDbContext context) : base(context) { } }
