namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Dtos.ResponseDtos;

public class LogStockLogStockReserveReasonResponseDto
{
    public Guid Id { get; set; }
    public Guid? FromReasonId { get; set; }
    public Guid? ToReasonId { get; set; }
    public LogStockReserveReasonResponseDto? FromReason { get; set; }
    public LogStockReserveReasonResponseDto? ToReason { get; set; }
}
