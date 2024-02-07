using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;

public interface IPrinterRepository : IAsyncRepository<Printer, Guid>, IRepository<Printer, Guid> { }