namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Dtos.ResponseDtos;

public class LogStockLogStockUnsuitReasonResponseDto
{
    public Guid Id { get; set; }
    public Guid? FromReasonId { get; set; }
    public Guid? ToReasonId { get; set; }
    public LogStockUnsuitReasonResponseDto? FromReason { get; set; }
    public LogStockUnsuitReasonResponseDto? ToReason { get; set; }
}
