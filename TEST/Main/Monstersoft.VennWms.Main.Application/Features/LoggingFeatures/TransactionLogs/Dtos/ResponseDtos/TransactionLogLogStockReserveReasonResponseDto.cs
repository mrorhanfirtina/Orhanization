namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Dtos.ResponseDtos;

public class TransactionLogLogStockReserveReasonResponseDto
{
    public Guid Id { get; set; }
    public Guid? FromReasonId { get; set; }
    public Guid? ToReasonId { get; set; }
    public TransactionLogReserveReasonResponseDto? FromReason { get; set; }
    public TransactionLogReserveReasonResponseDto? ToReason { get; set; }
}
