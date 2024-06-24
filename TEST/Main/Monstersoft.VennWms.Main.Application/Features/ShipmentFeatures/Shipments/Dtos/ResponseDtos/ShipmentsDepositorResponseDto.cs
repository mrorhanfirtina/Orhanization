namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Dtos.ResponseDtos;

public class ShipmentsDepositorResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public ShipmentsCompanyResponseDto? Company { get; set; }
}