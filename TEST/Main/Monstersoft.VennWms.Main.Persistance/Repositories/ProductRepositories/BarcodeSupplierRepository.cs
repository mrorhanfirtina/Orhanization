using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.ProductRepositories;

public class BarcodeSupplierRepository : EFRepositoryBase<BarcodeSupplier, Guid, BaseDbContext>, IBarcodeSupplierRepository { public BarcodeSupplierRepository(BaseDbContext context) : base(context) { } }
