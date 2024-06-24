using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Commands.Update;

public class UpdatedOrderPriorityResponse
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public int PriorityId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public OrderPriorityOrderResponseDto? Order { get; set; }
    public OrderPriorityPriorityListResponseDto? PriorityList { get; set; }
}


