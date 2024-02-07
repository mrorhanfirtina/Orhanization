using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;

public interface IReceiptRepository : IAsyncRepository<Receipt, Guid>, IRepository<Receipt, Guid> { }

