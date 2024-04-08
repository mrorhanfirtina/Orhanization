namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Queries.GetListByDynamic;

public class GetListByDynamicPoAttributeValueListItemDto
{
    public Guid Id { get; set; }
    public Guid PurchaseOrderId { get; set; }
    public Guid PoAttributeId { get; set; }
    public string Value { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}

