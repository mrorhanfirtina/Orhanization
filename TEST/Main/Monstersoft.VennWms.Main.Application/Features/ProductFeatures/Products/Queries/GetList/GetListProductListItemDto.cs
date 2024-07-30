using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Queries.GetList;

public class GetListProductListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public string AlternativeCode { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ProductProductAbcCategoryResponseDto? ProductAbcCategory { get; set; }
    public ProductProductCategoryResponseDto? ProductCategory { get; set; }
    public ProductDepositorCompanyResponseDto? DepositorCompany { get; set; }
}
