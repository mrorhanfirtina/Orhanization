using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;

public interface IBuildingRepository : IAsyncRepository<Building, Guid>, IRepository<Building, Guid> { }

