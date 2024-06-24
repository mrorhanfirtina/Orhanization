using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;

public interface IReceiptItmStockAttrValueRepository : IAsyncRepository<ReceiptItmStockAttrValue, Guid>, IRepository<ReceiptItmStockAttrValue, Guid> { }

