using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.PORepositories;

public interface IPurchaseOrderRepository : IAsyncRepository<PurchaseOrder, Guid>, IRepository<PurchaseOrder, Guid> { }

