namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ReceiptDtos;

public class CreateReceiptItemMemoDto
{
    public Guid ReceiptItemId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime EditDate { get; set; }
}

