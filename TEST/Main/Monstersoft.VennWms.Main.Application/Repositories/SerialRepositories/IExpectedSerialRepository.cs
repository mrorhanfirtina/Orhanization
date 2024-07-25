using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.SerialRepositories;

public interface IExpectedSerialRepository : IAsyncRepository<ExpectedSerial, Guid>, IRepository<ExpectedSerial, Guid> { }
