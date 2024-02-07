using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.LoggingRepositories;

public interface ILogStockContainerRepository : IAsyncRepository<LogStockContainer, Guid>, IRepository<LogStockContainer, Guid> { }

