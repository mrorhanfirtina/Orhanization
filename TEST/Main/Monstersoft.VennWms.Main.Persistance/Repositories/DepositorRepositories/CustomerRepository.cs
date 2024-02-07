using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.DepositorRepositories;

public class CustomerRepository : EFRepositoryBase<Customer, Guid, BaseDbContext>, ICustomerRepository { public CustomerRepository(BaseDbContext context) : base(context) { } }
