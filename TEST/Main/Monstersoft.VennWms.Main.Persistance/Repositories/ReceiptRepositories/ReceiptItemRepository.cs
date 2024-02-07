using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.ReceiptRepositories;

public class ReceiptItemRepository : EFRepositoryBase<ReceiptItem, Guid, BaseDbContext>, IReceiptItemRepository { public ReceiptItemRepository(BaseDbContext context) : base(context) { } }
