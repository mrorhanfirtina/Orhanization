using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;

public interface IDepositorCompanyRepository : IAsyncRepository<DepositorCompany, Guid>, IRepository<DepositorCompany, Guid> { }
