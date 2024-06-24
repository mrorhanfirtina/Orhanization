using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.BarcodeRepositories;

public class BarcodeAreaRepository : EFRepositoryBase<BarcodeArea, Guid, BaseDbContext>, IBarcodeAreaRepository { public BarcodeAreaRepository(BaseDbContext context) : base(context) { } }

