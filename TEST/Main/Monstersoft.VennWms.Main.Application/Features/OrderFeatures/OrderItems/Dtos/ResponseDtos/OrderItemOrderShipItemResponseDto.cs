namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Dtos.ResponseDtos;

public class OrderItemOrderShipItemResponseDto
{
    public int ProgressStatusId { get; set; }
    public decimal Quantity { get; set; }
    public OrderItemProgressStatusResponseDto? ProgressStatus { get; set; }
}
