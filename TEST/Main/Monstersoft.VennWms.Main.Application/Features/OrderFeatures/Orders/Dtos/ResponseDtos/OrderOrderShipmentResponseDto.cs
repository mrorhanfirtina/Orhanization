namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Dtos.ResponseDtos;

public class OrderOrderShipmentResponseDto
{
    public string Code { get; set; }
    public Guid ShipmentId { get; set; }
    public DateTime? LastMoveDate { get; set; }
    public int ProgressStatusId { get; set; }
    public OrderShipmentResponseDto? Shipment { get; set; }
    public OrderProgressStatusResponseDto? ProgressStatus { get; set; }
}
