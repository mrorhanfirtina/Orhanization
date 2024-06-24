namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Dtos.ResponseDtos;

public class StocksStockReserveReasonResponseDto
{
    public Guid Id { get; set; }
    public Guid ReserveReasonId { get; set; }
    public StocksReserveReasonResponseDto? ReserveReason { get; set; }
}