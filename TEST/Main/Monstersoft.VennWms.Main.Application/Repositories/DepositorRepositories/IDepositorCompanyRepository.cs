using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;

public interface IDepositorCompanyRepository : IAsyncRepository<DepositorCompany, Guid>, IRepository<DepositorCompany, Guid> { }
