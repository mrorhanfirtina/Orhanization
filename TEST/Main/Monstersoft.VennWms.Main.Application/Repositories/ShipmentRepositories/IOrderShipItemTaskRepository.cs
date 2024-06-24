using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;

public interface IOrderShipItemTaskRepository : IAsyncRepository<OrderShipItemTask, Guid>, IRepository<OrderShipItemTask, Guid> { }

