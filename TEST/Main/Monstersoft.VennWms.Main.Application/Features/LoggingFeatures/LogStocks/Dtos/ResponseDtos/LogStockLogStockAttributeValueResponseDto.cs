namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Dtos.ResponseDtos;

public class LogStockLogStockAttributeValueResponseDto
{
    public Guid Id { get; set; }
    public Guid LogStockId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string? FromValue { get; set; }
    public string? ToValue { get; set; }
    public LogStockStockAttributeResponseDto? StockAttribute { get; set; }
}
