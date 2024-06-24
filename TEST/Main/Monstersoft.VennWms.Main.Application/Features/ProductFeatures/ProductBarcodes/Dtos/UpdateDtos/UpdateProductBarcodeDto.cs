namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Dtos.UpdateDtos;

public class UpdateProductBarcodeDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public string BarcodeString { get; set; }
    public ICollection<UpdateBarcodeSupplierSubDto> BarcodeSuppliers { get; set; }
}

