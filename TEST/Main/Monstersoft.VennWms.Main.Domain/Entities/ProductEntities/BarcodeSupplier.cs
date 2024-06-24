using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

public class BarcodeSupplier : Entity<Guid>
{
    public Guid ProductBarcodeId { get; set; }
    public Guid SupplierId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public virtual Supplier? Supplier { get; set; }
    public virtual DepositorCompany? DepositorCompany { get; set; }
    public virtual ProductBarcode? ProductBarcode { get; set; }

    public BarcodeSupplier()
    {
    }

    public BarcodeSupplier(Guid productBarcodeId, Guid supplierId, Guid depositorCompanyId) : this()
    {
        ProductBarcodeId = productBarcodeId;
        SupplierId = supplierId;
        DepositorCompanyId = depositorCompanyId;
    }
}
