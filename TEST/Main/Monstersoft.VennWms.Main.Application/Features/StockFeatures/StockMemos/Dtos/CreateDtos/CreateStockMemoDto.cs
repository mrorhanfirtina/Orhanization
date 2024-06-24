namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Dtos.CreateDtos;

public class CreateStockMemoDto
{
    public Guid StockId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
}

