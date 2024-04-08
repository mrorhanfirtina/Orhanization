namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Queries.GetById;

public class GetByIdPoAttributeValueResponse
{
    public Guid Id { get; set; }
    public Guid PurchaseOrderId { get; set; }
    public Guid PoAttributeId { get; set; }
    public string Value { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}

