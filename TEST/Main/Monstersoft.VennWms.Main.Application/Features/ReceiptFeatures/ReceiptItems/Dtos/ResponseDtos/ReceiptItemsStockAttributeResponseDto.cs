namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Dtos.ResponseDtos;

public class ReceiptItemsStockAttributeResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public ReceiptItemsAttributeInputTypeResponseDto? AttributeInputType { get; set; }
}