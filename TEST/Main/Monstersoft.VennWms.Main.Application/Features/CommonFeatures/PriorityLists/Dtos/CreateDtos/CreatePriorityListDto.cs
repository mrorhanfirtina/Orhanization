namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Dtos.CreateDtos;

public class CreatePriorityListDto
{
    public string Code { get; set; }
    public string Description { get; set; }
    public int Priority { get; set; }
    public Guid DepositorCompanyId { get; set; }
}
