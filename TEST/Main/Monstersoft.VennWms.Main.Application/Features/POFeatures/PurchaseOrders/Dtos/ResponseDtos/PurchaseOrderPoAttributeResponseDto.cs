namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Dtos.ResponseDtos;

public class PurchaseOrderPoAttributeResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public PurchaseOrderAttributeInputTypeResponseDto? AttributeInputType { get; set; }
}
