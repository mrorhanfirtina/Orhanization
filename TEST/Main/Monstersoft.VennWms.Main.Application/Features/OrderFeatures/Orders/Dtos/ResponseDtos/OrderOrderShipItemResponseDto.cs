namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Dtos.ResponseDtos;

public class OrderOrderShipItemResponseDto
{
    public int ProgressStatusId { get; set; }
    public decimal Quantity { get; set; }
    public OrderProgressStatusResponseDto? ProgressStatus { get; set; }
}
