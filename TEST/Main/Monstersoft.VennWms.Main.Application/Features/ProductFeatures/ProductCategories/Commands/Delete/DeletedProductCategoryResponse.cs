namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Commands.Delete;

public class DeletedProductCategoryResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}

