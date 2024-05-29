namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Dtos.UpdateDtos;

public class UpdateProductBarcodeSubDto
{
    public string BarcodeString { get; set; }
    public ICollection<UpdateBarcodeSupplierSubDto> BarcodeSuppliers { get; set; }
}

