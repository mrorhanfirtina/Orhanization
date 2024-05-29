namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures;

public class UpdateStockMemoDto
{
    public Guid Id { get; set; }
    public Guid StockId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
}

