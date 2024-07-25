namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Dtos.ResponseDtos;

public class ActionParameterDepositorResponseDto
{
    public string Code { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public Guid CompanyId { get; set; }
    public ActionParameterCompanyResponseDto? Company { get; set; }
}
