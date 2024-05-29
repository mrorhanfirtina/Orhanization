namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Dtos.ResponseDtos;

public class TransactionLogLogStockAttributeValueResponseDto
{
    public Guid Id { get; set; }
    public Guid LogStockId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string? FromValue { get; set; }
    public string? ToValue { get; set; }
    public TransactionLogStockAttributeResponseDto? StockAttribute { get; set; }
}
