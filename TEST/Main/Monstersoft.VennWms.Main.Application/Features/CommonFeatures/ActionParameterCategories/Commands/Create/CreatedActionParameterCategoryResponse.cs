using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Commands.Create;

public class CreatedActionParameterCategoryResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<ActionParameterCategoryParameterResponseDto> ActionParameters { get; set; }
}
