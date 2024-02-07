using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;

public interface ITransactionTypeRepository : IAsyncRepository<TransactionType, int>, IRepository<TransactionType, int> { }

