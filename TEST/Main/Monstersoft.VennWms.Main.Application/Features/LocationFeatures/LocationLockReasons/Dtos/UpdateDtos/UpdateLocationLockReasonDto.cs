namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Dtos.UpdateDtos;

public class UpdateLocationLockReasonDto
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public int LockReasonId { get; set; }
}
