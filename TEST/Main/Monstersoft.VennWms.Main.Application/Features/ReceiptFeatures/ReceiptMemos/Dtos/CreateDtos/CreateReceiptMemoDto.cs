namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Dtos.CreateDtos;

public class CreateReceiptMemoDto
{
    public Guid ReceiptId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
}

