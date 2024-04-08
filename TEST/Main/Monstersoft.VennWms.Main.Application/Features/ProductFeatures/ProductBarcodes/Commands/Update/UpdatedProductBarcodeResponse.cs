using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Commands.Update;

public class UpdatedProductBarcodeResponse
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public string BarcodeString { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ICollection<BarcodeSupplier> BarcodeSuppliers { get; set; }

}


