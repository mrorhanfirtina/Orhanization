using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;

public interface IBarcodePrinterRepository : IAsyncRepository<BarcodePrinter, Guid>, IRepository<BarcodePrinter, Guid> { }