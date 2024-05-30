namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Dtos.ResponseDtos;

public class StocksStockContainerResponseDto
{
    public Guid Id { get; set; }
    public string Sscc { get; set; }
    public int ContainerUnitId { get; set; }
    public StocksContainerUnitResponseDto? ContainerUnit { get; set; }
}