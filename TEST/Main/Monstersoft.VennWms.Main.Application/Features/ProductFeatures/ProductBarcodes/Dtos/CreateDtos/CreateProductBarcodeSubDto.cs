using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Dtos.CreateDtos;

public class CreateProductBarcodeSubDto
{
    public string BarcodeString { get; set; }
    public ICollection<CreateBarcodeSupplierSubDto> BarcodeSuppliers { get; set; }
}

