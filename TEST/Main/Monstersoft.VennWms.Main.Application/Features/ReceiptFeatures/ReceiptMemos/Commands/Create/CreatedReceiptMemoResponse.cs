namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Commands.Create;

public class CreatedReceiptMemoResponse
{
    public Guid Id { get; set; }
    public Guid ReceiptId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime EditDate { get; set; }
    public DateTime CreatedDate { get; set; }

}
