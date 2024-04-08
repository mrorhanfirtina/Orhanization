namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Queries.GetList;

public class GetListLockReasonListItemDto
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}
