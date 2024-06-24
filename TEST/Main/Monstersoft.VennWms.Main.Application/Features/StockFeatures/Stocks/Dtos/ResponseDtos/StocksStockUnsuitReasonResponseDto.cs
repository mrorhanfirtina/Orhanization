namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Dtos.ResponseDtos;

public class StocksStockUnsuitReasonResponseDto
{
    public Guid Id { get; set; }
    public Guid UnsuitReasonId { get; set; }
    public StocksUnsuitReasonResponseDto? ReserveReason { get; set; }
}