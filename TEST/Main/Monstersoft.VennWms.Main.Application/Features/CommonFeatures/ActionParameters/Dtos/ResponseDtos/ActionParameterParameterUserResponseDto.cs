namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Dtos.ResponseDtos;

public class ActionParameterParameterUserResponseDto
{
    public Guid Id { get; set; }
    public int UserId { get; set; }
    public string Value { get; set; }
    public ActionParameterUserResponseDto? User { get; set; }
}
