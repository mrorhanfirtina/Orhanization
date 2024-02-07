using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;

public interface IShipmentTypeRepository : IAsyncRepository<ShipmentType, Guid>, IRepository<ShipmentType, Guid> { }

