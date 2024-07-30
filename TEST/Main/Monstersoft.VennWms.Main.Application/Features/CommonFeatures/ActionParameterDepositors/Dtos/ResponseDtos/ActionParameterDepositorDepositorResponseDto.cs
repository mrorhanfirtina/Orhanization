namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Dtos.ResponseDtos;

public class ActionParameterDepositorDepositorResponseDto
{
    public string Code { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public Guid CompanyId { get; set; }
    public ActionParameterDepositorCompanyResponseDto? Company { get; set; }
}
