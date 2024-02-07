using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;

public interface IOrderAttributeRepository : IAsyncRepository<OrderAttribute, Guid>, IRepository<OrderAttribute, Guid> { }

