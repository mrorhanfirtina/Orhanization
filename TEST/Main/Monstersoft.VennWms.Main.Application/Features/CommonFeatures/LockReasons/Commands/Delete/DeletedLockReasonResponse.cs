namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Commands.Delete;

public class DeletedLockReasonResponse
{
    public int Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}
