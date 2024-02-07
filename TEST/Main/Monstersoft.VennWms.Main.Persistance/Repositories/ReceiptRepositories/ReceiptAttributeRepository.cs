using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.ReceiptRepositories;

public class ReceiptAttributeRepository : EFRepositoryBase<ReceiptAttribute, Guid, BaseDbContext>, IReceiptAttributeRepository { public ReceiptAttributeRepository(BaseDbContext context) : base(context) { } }
