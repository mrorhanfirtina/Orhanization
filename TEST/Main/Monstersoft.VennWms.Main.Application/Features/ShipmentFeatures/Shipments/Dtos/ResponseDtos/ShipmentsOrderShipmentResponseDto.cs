namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Dtos.ResponseDtos;

public class ShipmentsOrderShipmentResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid OrderId { get; set; }
    public Guid ShipmentId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime? LastMoveDate { get; set; }
    public int ProgressStatusId { get; set; }
    public ShipmentsOrderResponseDto? Order { get; set; }
    public ICollection<ShipmentsOrderShipItemResponseDto>? OrderShipItems { get; set; }
    public ShipmentsDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public ShipmentsProgressStatusResponseDto? ProgressStatus { get; set; }
}