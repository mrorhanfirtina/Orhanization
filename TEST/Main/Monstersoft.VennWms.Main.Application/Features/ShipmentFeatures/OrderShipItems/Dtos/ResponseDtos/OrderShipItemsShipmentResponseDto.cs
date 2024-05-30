namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Dtos.ResponseDtos;

public class OrderShipItemsShipmentResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
}