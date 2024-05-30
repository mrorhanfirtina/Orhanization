namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Dtos.ResponseDtos;

public class StocksItemUnitResponseDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public int UnitId { get; set; }
    public StocksUnitResponseDto? Unit { get; set; }
}