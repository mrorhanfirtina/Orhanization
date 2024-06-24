using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Commands.Create;

public class CreatedOrderPriorityResponse
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public int PriorityId { get; set; }
    public DateTime CreatedDate { get; set; }
    public OrderPriorityOrderResponseDto? Order { get; set; }
    public OrderPriorityPriorityListResponseDto? PriorityList { get; set; }
}


