namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Dtos.ResponseDtos;

public class StocksProductBarcodeResponseDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid? ItemUnitId { get; set; }
    public string BarcodeString { get; set; }
}