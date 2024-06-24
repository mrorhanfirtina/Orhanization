using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;

public interface IOrderAttributeValueRepository : IAsyncRepository<OrderAttributeValue, Guid>, IRepository<OrderAttributeValue, Guid> { }

