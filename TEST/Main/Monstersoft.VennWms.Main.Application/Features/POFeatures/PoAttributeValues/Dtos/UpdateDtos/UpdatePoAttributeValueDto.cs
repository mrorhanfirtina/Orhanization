namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Dtos.UpdateDtos;

public class UpdatePoAttributeValueDto
{
    public Guid Id { get; set; }
    public Guid PurchaseOrderId { get; set; }
    public Guid PoAttributeId { get; set; }
    public string Value { get; set; }
}

