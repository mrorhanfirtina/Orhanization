using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.LoggingRepositories;

public interface ILogStockAttributeValueRepository : IAsyncRepository<LogStockAttributeValue, Guid>, IRepository<LogStockAttributeValue, Guid> { }

