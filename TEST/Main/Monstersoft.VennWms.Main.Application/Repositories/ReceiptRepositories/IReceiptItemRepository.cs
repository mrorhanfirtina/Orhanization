using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;

public interface IReceiptItemRepository : IAsyncRepository<ReceiptItem, Guid>, IRepository<ReceiptItem, Guid> { }

