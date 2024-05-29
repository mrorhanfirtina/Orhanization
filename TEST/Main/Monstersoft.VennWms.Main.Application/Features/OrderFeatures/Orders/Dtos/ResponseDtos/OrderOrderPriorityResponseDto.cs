namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Dtos.ResponseDtos;

public class OrderOrderPriorityResponseDto
{
    public Guid Id { get; set; }
    public int PriorityId { get; set; }
    public OrderPriorityListResponseDto? Priority { get; set; }
}
