using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Commands.Update;

public class UpdatedReceiptItemMemoResponse
{
    public Guid Id { get; set; }
    public Guid ReceiptItemId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? EditDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ReceiptItemMemosReceiptItemResponseDto? ReceiptItem { get; set; }
}
