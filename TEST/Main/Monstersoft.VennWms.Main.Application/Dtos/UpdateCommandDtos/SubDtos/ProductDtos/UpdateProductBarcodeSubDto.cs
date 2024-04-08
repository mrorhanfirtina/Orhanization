namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ProductDtos;

public class UpdateProductBarcodeSubDto
{
    public string BarcodeString { get; set; }
    public ICollection<UpdateBarcodeSupplierSubDto> BarcodeSuppliers { get; set; }
}

