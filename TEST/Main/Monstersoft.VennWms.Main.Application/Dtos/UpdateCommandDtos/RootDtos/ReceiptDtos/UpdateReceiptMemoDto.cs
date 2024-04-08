namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ReceiptDtos;

public class UpdateReceiptMemoDto
{
    public Guid Id { get; set; }
    public Guid ReceiptId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
}

