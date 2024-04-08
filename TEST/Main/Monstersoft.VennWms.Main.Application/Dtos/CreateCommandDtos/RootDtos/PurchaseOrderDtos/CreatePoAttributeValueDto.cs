namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.PurchaseOrderDtos;

public class CreatePoAttributeValueDto
{
    public Guid PurchaseOrderId { get; set; }
    public Guid PoAttributeId { get; set; }
    public string Value { get; set; }
}

