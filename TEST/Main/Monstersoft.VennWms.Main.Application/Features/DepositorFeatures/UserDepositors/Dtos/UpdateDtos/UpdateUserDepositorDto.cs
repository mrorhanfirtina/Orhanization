namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Dtos.UpdateDtos;

public class UpdateUserDepositorDto
{
    public Guid Id { get; set; }
    public int UserId { get; set; }
    public Guid DepositorId { get; set; }
}
