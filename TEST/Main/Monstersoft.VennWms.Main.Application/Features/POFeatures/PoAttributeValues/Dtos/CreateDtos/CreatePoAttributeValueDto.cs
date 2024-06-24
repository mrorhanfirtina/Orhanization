namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Dtos.CreateDtos;

public class CreatePoAttributeValueDto
{
    public Guid PurchaseOrderId { get; set; }
    public Guid PoAttributeId { get; set; }
    public string Value { get; set; }
}

