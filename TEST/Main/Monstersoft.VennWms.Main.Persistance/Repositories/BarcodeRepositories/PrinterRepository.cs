using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.BarcodeRepositories;

public class PrinterRepository : EFRepositoryBase<Printer, Guid, BaseDbContext>, IPrinterRepository { public PrinterRepository(BaseDbContext context) : base(context) { } }
