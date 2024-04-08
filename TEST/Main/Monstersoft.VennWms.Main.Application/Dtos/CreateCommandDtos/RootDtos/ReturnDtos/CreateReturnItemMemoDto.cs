namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ReturnDtos;

public class CreateReturnItemMemoDto
{
    public Guid ReturnItemId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime EditDate { get; set; }
}

