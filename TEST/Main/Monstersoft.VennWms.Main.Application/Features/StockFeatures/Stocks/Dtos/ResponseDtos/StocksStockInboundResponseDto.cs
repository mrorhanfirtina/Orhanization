namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Dtos.ResponseDtos;

public class StocksStockInboundResponseDto
{
    public Guid Id { get; set; }
    public Guid? ReceiptId { get; set; }
    public Guid? ReturnId { get; set; }
    public Guid CuItemUnitId { get; set; }
    public decimal CuQuantity { get; set; }
    public decimal CuQuantityFree { get; set; }
    public StocksReceiptResponseDto? Receipt { get; set; }
    public StocksReturnResponseDto? Return { get; set; }
}