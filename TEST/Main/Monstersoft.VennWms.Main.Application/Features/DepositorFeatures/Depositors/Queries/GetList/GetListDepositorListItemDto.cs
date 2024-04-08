namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Queries.GetList;

public class GetListDepositorListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}
