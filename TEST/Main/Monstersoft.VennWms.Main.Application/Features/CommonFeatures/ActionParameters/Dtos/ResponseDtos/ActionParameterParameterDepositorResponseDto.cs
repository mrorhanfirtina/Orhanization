namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Dtos.ResponseDtos;

public class ActionParameterParameterDepositorResponseDto
{
    public Guid Id { get; set; }
    public Guid DepositorId { get; set; }
    public string Value { get; set; }
    public ActionParameterDepositorResponseDto? Depositor { get; set; }
}
