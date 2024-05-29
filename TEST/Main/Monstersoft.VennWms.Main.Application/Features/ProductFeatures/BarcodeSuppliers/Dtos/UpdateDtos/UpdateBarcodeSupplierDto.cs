namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures;

public class UpdateBarcodeSupplierDto
{
    public Guid Id { get; set; }
    public Guid ProductBarcodeId { get; set; }
    public Guid SupplierId { get; set; }
}

