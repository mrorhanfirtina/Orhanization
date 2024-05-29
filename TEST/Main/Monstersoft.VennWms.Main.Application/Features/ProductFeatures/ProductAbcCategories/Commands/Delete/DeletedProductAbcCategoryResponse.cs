namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Commands.Delete;

public class DeletedProductAbcCategoryResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}


