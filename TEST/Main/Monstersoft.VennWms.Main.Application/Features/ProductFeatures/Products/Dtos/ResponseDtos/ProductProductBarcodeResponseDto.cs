namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.ResponseDtos;

public class ProductProductBarcodeResponseDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid? ItemUnitId { get; set; }
    public string BarcodeString { get; set; }
    public ICollection<ProductBarcodeSupplierResponseDto>? BarcodeSuppliers { get; set; }
}
