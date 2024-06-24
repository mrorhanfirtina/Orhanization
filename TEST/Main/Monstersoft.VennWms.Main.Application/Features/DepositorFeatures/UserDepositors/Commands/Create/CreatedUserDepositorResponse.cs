using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Commands.Create;

public class CreatedUserDepositorResponse
{
    public Guid Id { get; set; }
    public int UserId { get; set; }
    public UserDepositorUserResponseDto? User { get; set; }
    public UserDepositorDepositorResponseDto? Depositor { get; set; }

}

