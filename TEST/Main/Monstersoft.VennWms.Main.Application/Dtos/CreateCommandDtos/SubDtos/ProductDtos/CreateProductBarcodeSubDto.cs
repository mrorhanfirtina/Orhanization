namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ProductDtos;

public class CreateProductBarcodeSubDto
{
    public string BarcodeString { get; set; }
    public ICollection<CreateBarcodeSupplierSubDto> BarcodeSuppliers { get; set; }
}

