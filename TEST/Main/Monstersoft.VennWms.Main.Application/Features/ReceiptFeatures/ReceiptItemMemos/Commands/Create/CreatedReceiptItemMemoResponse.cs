namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Commands.Create;

public class CreatedReceiptItemMemoResponse
{
    public Guid Id { get; set; }
    public Guid ReceiptItemId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime EditDate { get; set; }
    public DateTime CreatedDate { get; set; }

}
