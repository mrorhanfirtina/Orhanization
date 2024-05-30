namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Dtos.ResponseDtos;

public class ReceiptItemsProductResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public string? AlternativeCode { get; set; }
}