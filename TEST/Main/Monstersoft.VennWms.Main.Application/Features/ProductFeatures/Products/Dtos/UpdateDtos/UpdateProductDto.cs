using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.UpdateDtos;

public class UpdateProductDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public string AlternativeCode { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public ICollection<UpdateProductAttributeValueSubDto>? ProductAttributeValues { get; set; }
    public ICollection<UpdateProductBarcodeSubDto>? ProductBarcodes { get; set; }
    public ICollection<UpdateItemUnitSubDto>? ItemUnits { get; set; }
    public ICollection<UpdateProductStockAttributeSubDto>? ProductStockAttributes { get; set; }
    public ICollection<UpdateProductDepositorSubDto>? ProductDepositors { get; set; }
    public UpdateProductAbcCategorySubDto? ProductAbcCategory { get; set; }
    public UpdateProductCategorySubDto? ProductCategory { get; set; }
}

