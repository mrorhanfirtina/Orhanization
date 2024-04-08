namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Queries.GetListByDynamic;

public class GetListByDynamicDepositorListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}
