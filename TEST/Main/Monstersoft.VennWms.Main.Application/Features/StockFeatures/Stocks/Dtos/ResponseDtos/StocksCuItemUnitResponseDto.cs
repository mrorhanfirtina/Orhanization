namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Dtos.ResponseDtos;

public class StocksCuItemUnitResponseDto
{
    public Guid Id { get; set; }
    public int UnitId { get; set; }
    public ICollection<StocksItemPackTypeResponseDto>? ItemPackTypes { get; set; }
    public StocksUnitResponseDto? Unit { get; set; }
}