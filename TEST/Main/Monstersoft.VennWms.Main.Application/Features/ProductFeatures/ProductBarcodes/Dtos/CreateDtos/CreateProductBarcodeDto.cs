using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Dtos.CreateDtos;

public class CreateProductBarcodeDto
{
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public string BarcodeString { get; set; }
    public ICollection<CreateBarcodeSupplierSubDto> BarcodeSuppliers { get; set; }
}

