namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists;

public class DeletedProductCategoryListResponse
{
    public int Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}


