using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;

public interface ILocationCodeComponentRepository : IAsyncRepository<LocationCodeComponent, int>, IRepository<LocationCodeComponent, int> { }
