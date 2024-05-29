namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Dtos.ResponseDtos;

public class ProductBarcodeBarcodeSupplierSupplierResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid CompanyId { get; set; }
    public ProductBarcodeCompanyResponseDto? Company { get; set; }
}
