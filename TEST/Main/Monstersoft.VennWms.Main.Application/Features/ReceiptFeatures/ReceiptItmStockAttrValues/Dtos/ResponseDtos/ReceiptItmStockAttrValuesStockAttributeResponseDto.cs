namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Dtos.ResponseDtos;

public class ReceiptItmStockAttrValuesStockAttributeResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public ReceiptItmStockAttrValuesAttributeInputTypeResponseDto? AttributeInputType { get; set; }
}