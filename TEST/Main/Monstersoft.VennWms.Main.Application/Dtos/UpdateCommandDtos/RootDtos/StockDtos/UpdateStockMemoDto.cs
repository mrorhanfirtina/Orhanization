namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.StockDtos;

public class UpdateStockMemoDto
{
    public Guid Id { get; set; }
    public Guid StockId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
}

