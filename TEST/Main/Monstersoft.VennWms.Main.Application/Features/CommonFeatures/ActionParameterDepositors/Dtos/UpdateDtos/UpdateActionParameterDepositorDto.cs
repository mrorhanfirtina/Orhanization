namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Dtos.UpdateDtos;

public class UpdateActionParameterDepositorDto
{
    public Guid Id { get; set; }
    public int ActionParameterId { get; set; }
    public Guid DepositorId { get; set; }
    public string Value { get; set; }
}
