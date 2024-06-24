using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Commands.Create;

public class CreatedLocationLockReasonResponse
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public int LockReasonId { get; set; }
    public DateTime CreatedDate { get; set; }
    public LocationLockReasonLocationResponseDto? Location { get; set; }
    public LocationLockReasonLockReasonResponseDto? LockReason { get; set; }
}


