using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Repositories.LoggingRepositories;

public interface ILogStockRepository : IAsyncRepository<LogStock, Guid>, IRepository<LogStock, Guid> { }

