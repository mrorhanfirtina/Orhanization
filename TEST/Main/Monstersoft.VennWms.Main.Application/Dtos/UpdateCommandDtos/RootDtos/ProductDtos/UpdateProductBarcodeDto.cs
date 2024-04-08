using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ProductDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ProductDtos;

public class UpdateProductBarcodeDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public string BarcodeString { get; set; }
    public ICollection<UpdateBarcodeSupplierSubDto> BarcodeSuppliers { get; set; }
}

