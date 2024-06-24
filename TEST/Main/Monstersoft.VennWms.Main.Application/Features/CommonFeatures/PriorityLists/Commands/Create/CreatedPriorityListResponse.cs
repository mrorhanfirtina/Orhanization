using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Commands.Create;

public class CreatedPriorityListResponse
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int Priority { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public PriorityListDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public DateTime CreatedDate { get; set; }
}



