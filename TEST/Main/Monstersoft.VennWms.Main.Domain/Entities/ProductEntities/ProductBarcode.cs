using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

public class ProductBarcode : Entity<Guid>
{
    public Guid ProductId { get; set; }
    public Guid? ItemUnitId { get; set; }
    public string BarcodeString { get; set; }
    public virtual ICollection<BarcodeSupplier>? BarcodeSuppliers { get; set; }
    public virtual Product? Product { get; set; }
    public virtual ItemUnit? ItemUnit { get; set; }

    public ProductBarcode()
    {
        BarcodeSuppliers = new HashSet<BarcodeSupplier>();
    }

    public ProductBarcode(Guid id, Guid productId, string barcodeString) : this()
    {
        Id = id;
        ProductId = productId;
        BarcodeString = barcodeString;
    }

    
}
