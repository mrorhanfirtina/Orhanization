using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Commands.Update;

public class UpdatedPoAttributeValueResponse
{
    public Guid Id { get; set; }
    public Guid PurchaseOrderId { get; set; }
    public Guid PoAttributeId { get; set; }
    public string Value { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public PoAttributeValuePoAttributeResponseDto? PoAttribute { get; set; }
    public PoAttributeValuePurchaseOrderResponseDto? PurchaseOrder { get; set; }

}

