using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults;

public class UpdatedActionParameterDefaultResponse
{
    public Guid Id { get; set; }
    public int ActionParameterId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Value { get; set; }
    public ActionParameterDefaultDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public ActionParameterDefaultParameterResponseDto? ActionParameter { get; set; }
}
