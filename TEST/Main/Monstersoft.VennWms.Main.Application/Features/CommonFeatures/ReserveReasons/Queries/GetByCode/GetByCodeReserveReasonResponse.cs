namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Queries.GetByCode;

public class GetByCodeReserveReasonResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public bool IsBlocked { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}
