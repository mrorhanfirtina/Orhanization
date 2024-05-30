using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Queries.GetListByDynamic;

public class GetListByDynamicOrderShipmentListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid OrderId { get; set; }
    public Guid ShipmentId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime? LastMoveDate { get; set; }
    public int ProgressStatusId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public OrderShipmentsOrderResponseDto? Order { get; set; }
    public ICollection<OrderShipmentsOrderShipItemResponseDto>? OrderShipItems { get; set; }
    public OrderShipmentsShipmentResponseDto? Shipment { get; set; }
    public OrderShipmentsDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public OrderShipmentsProgressStatusResponseDto? ProgressStatus { get; set; }
}
