using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;

public interface IReturnMemoRepository : IAsyncRepository<ReturnMemo, Guid>, IRepository<ReturnMemo, Guid> { }

