namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Commands.Delete;

public class DeletedActionParameterCategoryResponse
{
    public int Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}
