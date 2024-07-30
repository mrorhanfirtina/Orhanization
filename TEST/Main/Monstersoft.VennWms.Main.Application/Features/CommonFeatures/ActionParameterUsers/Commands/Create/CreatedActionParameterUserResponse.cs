using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Commands.Create;

public class CreatedActionParameterUserResponse
{
    public Guid Id { get; set; }
    public int ActionParameterId { get; set; }
    public int UserId { get; set; }
    public string Value { get; set; }
    public ActionParameterUserParameterResponseDto? ActionParameter { get; set; }
    public ActionParameterUserUserResponseDto? User { get; set; }
}
