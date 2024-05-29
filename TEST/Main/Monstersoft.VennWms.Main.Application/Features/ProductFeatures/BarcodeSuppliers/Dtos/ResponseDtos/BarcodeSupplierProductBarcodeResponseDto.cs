namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Dtos.ResponseDtos;

public class BarcodeSupplierProductBarcodeResponseDto
{
    public Guid ProductId { get; set; }
    public Guid? ItemUnitId { get; set; }
    public string BarcodeString { get; set; }
}
