namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.ResponseDtos;

public class LocationLocationLockReasonResponseDto
{
    public Guid Id { get; set; }
    public int LockReasonId { get; set; }
    public virtual LocationLockReasonResponseDto? LockReason { get; set; }
}
