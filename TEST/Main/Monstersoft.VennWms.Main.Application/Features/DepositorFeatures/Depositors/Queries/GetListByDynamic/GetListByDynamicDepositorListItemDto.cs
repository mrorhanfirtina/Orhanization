using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Queries.GetListByDynamic;

public class GetListByDynamicDepositorListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid CompanyId { get; set; }
    public DepositorCompanyResponseDto? Company { get; set; }
    public DepositorDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public DepositorDepositorFeatureResponseDto? DepositorFeature { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}
