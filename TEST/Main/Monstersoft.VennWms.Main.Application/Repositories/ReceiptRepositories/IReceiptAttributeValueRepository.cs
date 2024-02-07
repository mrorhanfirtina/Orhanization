using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;

public interface IReceiptAttributeValueRepository : IAsyncRepository<ReceiptAttributeValue, Guid>, IRepository<ReceiptAttributeValue, Guid> { }

