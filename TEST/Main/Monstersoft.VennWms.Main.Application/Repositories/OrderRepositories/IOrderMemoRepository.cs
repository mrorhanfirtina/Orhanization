using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;

public interface IOrderMemoRepository : IAsyncRepository<OrderMemo, Guid>, IRepository<OrderMemo, Guid> { }

