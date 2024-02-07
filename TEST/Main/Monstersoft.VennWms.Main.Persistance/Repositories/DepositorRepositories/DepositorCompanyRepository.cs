using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.DepositorRepositories;

public class DepositorCompanyRepository : EFRepositoryBase<DepositorCompany, Guid, BaseDbContext>, IDepositorCompanyRepository { public DepositorCompanyRepository(BaseDbContext context) : base(context) { } }

