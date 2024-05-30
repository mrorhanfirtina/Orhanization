namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Dtos.ResponseDtos;

public class ShipmentMemosShipmentResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
}