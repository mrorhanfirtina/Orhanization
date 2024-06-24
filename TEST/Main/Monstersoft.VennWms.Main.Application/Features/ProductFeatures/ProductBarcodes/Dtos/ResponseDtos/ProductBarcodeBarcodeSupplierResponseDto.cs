namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Dtos.ResponseDtos;

public class ProductBarcodeBarcodeSupplierResponseDto
{
    public Guid Id { get; set; }
    public Guid SupplierId { get; set; }
    public ProductBarcodeBarcodeSupplierSupplierResponseDto? Supplier { get; set; }
}
