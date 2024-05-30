namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Dtos.ResponseDtos;

public class ShipmentsProductResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public string? AlternativeCode { get; set; }
}
