using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ProductDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ProductDtos;

public class UpdateProductDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public string AlternativeCode { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public ICollection<UpdateProductAttributeValueSubDto> ProductAttributeValues { get; set; }
    public ICollection<UpdateProductBarcodeSubDto> ProductBarcodes { get; set; }
    public ICollection<UpdateItemUnitSubDto> ItemUnits { get; set; }
    public ICollection<UpdateProductStockAttributeSubDto> ProductStockAttributes { get; set; }
    public ICollection<UpdateProductDepositorSubDto> ProductDepositors { get; set; }
}

