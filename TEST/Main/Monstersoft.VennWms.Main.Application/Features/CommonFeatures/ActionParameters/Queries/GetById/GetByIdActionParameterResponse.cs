using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Queries.GetById;

public class GetByIdActionParameterResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string DefaultValue { get; set; }
    public int CategoryId { get; set; }
    public ActionParameterParameterCategoryResponseDto? ActionParameterCategory { get; set; }
    public ICollection<ActionParameterParameterUserResponseDto>? ActionParameterUsers { get; set; }
    public ICollection<ActionParameterParameterDepositorResponseDto>? ActionParameterDepositors { get; set; }
}
