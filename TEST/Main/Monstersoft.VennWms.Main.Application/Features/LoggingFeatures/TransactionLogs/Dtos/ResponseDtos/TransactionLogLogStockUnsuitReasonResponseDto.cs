namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Dtos.ResponseDtos;

public class TransactionLogLogStockUnsuitReasonResponseDto
{
    public Guid Id { get; set; }
    public Guid? FromReasonId { get; set; }
    public Guid? ToReasonId { get; set; }
    public TransactionLogUnsuitReasonResponseDto? FromReason { get; set; }
    public TransactionLogUnsuitReasonResponseDto? ToReason { get; set; }
}
