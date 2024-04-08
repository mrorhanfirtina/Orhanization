namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LocationDtos;

public class UpdateLocationLockReasonDto
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public int LockReasonId { get; set; }
}
