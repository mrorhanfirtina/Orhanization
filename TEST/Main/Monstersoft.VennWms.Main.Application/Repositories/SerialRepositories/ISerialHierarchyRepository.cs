using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.SerialRepositories;

public interface ISerialHierarchyRepository : IAsyncRepository<SerialHierarchy, Guid>, IRepository<SerialHierarchy, Guid> { }
