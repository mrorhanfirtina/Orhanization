namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Dtos.ResponseDtos;

public class OrderShipItemsProductResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public string? AlternativeCode { get; set; }
}