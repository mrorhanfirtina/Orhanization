namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Commands.Update;

public class UpdatedLockReasonResponse
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}
