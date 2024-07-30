namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Dtos.ResponseDtos;

public class ActionParameterDepositorParameterResponseDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string DefaultValue { get; set; }
    public int CategoryId { get; set; }
    public ActionParameterDepositorParameterCategoryResponseDto? Category { get; set; }
}
