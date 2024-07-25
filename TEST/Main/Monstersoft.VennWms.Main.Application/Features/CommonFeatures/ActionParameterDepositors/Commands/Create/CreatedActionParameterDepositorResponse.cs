using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Commands.Create;

public class CreatedActionParameterDepositorResponse
{
    public Guid Id { get; set; }
    public int ActionParameterId { get; set; }
    public Guid DepositorId { get; set; }
    public string Value { get; set; }
    public ActionParameterDepositorParameterResponseDto? ActionParameter { get; set; }
    public ActionParameterDepositorDepositorResponseDto? Depositor { get; set; }
}
