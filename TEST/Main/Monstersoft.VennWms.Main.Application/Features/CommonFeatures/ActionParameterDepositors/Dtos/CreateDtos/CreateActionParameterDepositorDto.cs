namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Dtos.CreateDtos;

public class CreateActionParameterDepositorDto
{
    public int ActionParameterId { get; set; }
    public Guid DepositorId { get; set; }
    public string Value { get; set; }
}
