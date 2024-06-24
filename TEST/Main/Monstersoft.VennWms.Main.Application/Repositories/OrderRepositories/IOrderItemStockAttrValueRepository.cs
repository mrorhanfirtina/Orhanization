using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;

public interface IOrderItemStockAttrValueRepository : IAsyncRepository<OrderItemStockAttrValue, Guid>, IRepository<OrderItemStockAttrValue, Guid> { }

