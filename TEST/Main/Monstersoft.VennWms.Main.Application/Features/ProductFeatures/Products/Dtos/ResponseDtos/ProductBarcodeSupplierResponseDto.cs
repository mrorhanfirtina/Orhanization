namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.ResponseDtos;

public class ProductBarcodeSupplierResponseDto
{
    public Guid Id { get; set; }
    public Guid SupplierId { get; set; }
    public ProductSupplierResponseDto? Supplier { get; set; }
}
