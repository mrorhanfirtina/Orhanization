namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Queries.GetById;

public class GetByIdDepositorResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}
