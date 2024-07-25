namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Dtos.ResponseDtos;

public class ActionParameterUserParameterResponseDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string DefaultValue { get; set; }
    public int CategoryId { get; set; }
    public ActionParameterUserParameterCategoryResponseDto? Category { get; set; }
}
