using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Queries.GetListByDynamic;

public class GetListByDynamicUserDepositorListItemDto 
{
    public Guid Id { get; set; }
    public UserDepositorUserResponseDto? User { get; set; }
    public UserDepositorDepositorResponseDto? Depositor { get; set; }
}
