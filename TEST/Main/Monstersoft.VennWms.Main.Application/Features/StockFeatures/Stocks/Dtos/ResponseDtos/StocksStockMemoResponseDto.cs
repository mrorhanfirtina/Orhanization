namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Dtos.ResponseDtos;

public class StocksStockMemoResponseDto
{
    public Guid Id { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? EditDate { get; set; }
}