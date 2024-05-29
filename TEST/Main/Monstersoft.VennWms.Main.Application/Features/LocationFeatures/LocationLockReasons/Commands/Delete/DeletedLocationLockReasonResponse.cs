namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Commands.Delete;

public class DeletedLocationLockReasonResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}


