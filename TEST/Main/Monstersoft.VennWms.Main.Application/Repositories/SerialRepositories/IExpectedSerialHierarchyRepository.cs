using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.SerialRepositories;

public interface IExpectedSerialHierarchyRepository : IAsyncRepository<ExpectedSerialHierarchy, Guid>, IRepository<ExpectedSerialHierarchy, Guid> { }
