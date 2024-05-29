namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Dtos.ResponseDtos;

public class PurchaseOrderPoAttributeValueResponseDto
{
    public Guid Id { get; set; }
    public Guid PoAttributeId { get; set; }
    public string Value { get; set; }
    public PurchaseOrderPoAttributeResponseDto? PoAttribute { get; set; }
}
