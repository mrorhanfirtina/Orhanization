using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.CreateDtos;

public class CreateProductDto
{
    public string Code { get; set; }
    public string Description { get; set; }
    public string AlternativeCode { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public ICollection<CreateProductAttributeValueSubDto>? ProductAttributeValues { get; set; }
    public ICollection<CreateProductBarcodeSubDto>? ProductBarcodes { get; set; }
    public ICollection<CreateItemUnitSubDto>? ItemUnits { get; set; }
    public ICollection<CreateProductStockAttributeSubDto>? ProductStockAttributes { get; set; }
    public ICollection<CreateProductDepositorSubDto>? ProductDepositors { get; set; }
    public CreateProductAbcCategorySubDto? ProductAbcCategory { get; set; }
    public CreateProductCategorySubDto? ProductCategory { get; set; }
}

