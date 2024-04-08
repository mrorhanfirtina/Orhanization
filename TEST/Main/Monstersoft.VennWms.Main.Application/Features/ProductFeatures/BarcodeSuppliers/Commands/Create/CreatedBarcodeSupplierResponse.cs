namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Commands.Create;

public class CreatedBarcodeSupplierResponse
{
    public Guid Id { get; set; }
    public Guid ProductBarcodeId { get; set; }
    public Guid SupplierId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }

}
