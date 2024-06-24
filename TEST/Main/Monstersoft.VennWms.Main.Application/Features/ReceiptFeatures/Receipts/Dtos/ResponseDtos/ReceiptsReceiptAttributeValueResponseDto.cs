namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Dtos.ResponseDtos;

public class ReceiptsReceiptAttributeValueResponseDto
{
    public Guid Id { get; set; }
    public Guid ReceiptAttributeId { get; set; }
    public string Value { get; set; }
    public ReceiptsReceiptAttributeResponseDto? ReceiptAttribute { get; set; }
}
