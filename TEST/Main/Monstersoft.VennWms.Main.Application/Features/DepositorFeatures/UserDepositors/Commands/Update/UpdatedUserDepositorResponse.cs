using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Commands.Update;

public class UpdatedUserDepositorResponse
{
    public Guid Id { get; set; }
    public int UserId { get; set; }
    public Guid DepositorId { get; set; }
    public UserDepositorUserResponseDto? User { get; set; }
    public UserDepositorDepositorResponseDto? Depositor { get; set; }
}

