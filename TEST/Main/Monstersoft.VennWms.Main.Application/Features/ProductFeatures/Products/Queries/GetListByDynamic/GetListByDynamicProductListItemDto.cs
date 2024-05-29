using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Queries.GetListByDynamic;

public class GetListByDynamicProductListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public string AlternativeCode { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ICollection<ProductProductAttributeValueResponseDto?> ProductAttributeValues { get; set; }
    public ICollection<ProductProductBarcodeResponseDto?> ProductBarcodes { get; set; }
    public ICollection<ProductItemUnitResponseDto?> ItemUnits { get; set; }
    public ICollection<ProductProductDepositorResponseDto?> ProductDepositors { get; set; }
    public ICollection<ProductProductStockAttributeResponseDto?> ProductStockAttributes { get; set; }
    public ProductProductAbcCategoryResponseDto? ProductAbcCategory { get; set; }
    public ProductProductCategoryResponseDto? ProductCategory { get; set; }
    public ProductDepositorCompanyResponseDto? DepositorCompany { get; set; }
}
