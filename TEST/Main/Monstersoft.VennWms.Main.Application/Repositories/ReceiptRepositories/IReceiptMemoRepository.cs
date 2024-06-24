using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;

public interface IReceiptMemoRepository : IAsyncRepository<ReceiptMemo, Guid>, IRepository<ReceiptMemo, Guid> { }

