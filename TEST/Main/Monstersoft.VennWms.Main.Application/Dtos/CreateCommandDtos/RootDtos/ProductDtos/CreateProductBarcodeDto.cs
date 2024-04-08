using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ProductDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ProductDtos;

public class CreateProductBarcodeDto
{
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public string BarcodeString { get; set; }
    public ICollection<CreateBarcodeSupplierSubDto> BarcodeSuppliers { get; set; }
}

