using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.PORepositories;

public interface IPoMemoRepository : IAsyncRepository<PoMemo, Guid>, IRepository<PoMemo, Guid> { }

