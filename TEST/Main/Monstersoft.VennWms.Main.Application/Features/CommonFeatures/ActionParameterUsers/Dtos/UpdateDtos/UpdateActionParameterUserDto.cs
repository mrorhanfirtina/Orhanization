namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Dtos.UpdateDtos;

public class UpdateActionParameterUserDto
{
    public Guid Id { get; set; }
    public int ActionParameterId { get; set; }
    public int UserId { get; set; }
    public string Value { get; set; }
}
