namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Dtos.ResponseDtos;

public class ReceiptItemsReceiptItemMemoResponseDto
{
    public Guid Id { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? EditDate { get; set; }
}