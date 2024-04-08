namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Commands.Update;

public class UpdatedBarcodeSupplierResponse
{
    public Guid Id { get; set; }
    public Guid ProductBarcodeId { get; set; }
    public Guid SupplierId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}
