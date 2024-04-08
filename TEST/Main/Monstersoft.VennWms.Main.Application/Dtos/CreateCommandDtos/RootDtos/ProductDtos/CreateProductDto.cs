using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ProductDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ProductDtos;

public class CreateProductDto
{
    public string Code { get; set; }
    public string Description { get; set; }
    public string AlternativeCode { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public ICollection<CreateProductAttributeValueSubDto> ProductAttributeValues { get; set; }
    public ICollection<CreateProductBarcodeSubDto> ProductBarcodes { get; set; }
    public ICollection<CreateItemUnitSubDto> ItemUnits { get; set; }
    public ICollection<CreateProductStockAttributeSubDto> ProductStockAttributes { get; set; }
    public ICollection<CreateProductDepositorSubDto> ProductDepositors { get; set; }
}

