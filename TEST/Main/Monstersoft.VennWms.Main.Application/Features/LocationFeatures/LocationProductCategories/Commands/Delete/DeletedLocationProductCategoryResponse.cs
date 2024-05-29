namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Commands.Delete;

public class DeletedLocationProductCategoryResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}

