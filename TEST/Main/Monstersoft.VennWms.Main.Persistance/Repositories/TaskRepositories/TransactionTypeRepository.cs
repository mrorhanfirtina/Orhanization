using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.TaskRepositories;

public class TransactionTypeRepository : EFRepositoryBase<TransactionType, int, BaseDbContext>, ITransactionTypeRepository { public TransactionTypeRepository(BaseDbContext context) : base(context) { } }
