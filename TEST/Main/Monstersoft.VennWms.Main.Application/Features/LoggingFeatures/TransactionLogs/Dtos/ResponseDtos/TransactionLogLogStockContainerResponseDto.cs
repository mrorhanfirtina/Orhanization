using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Dtos.ResponseDtos;

public class TransactionLogLogStockContainerResponseDto
{
    public Guid Id { get; set; }
    public Guid? FromContainerId { get; set; }
    public Guid? ToContainerId { get; set; }
    public string? FromContainerSSCC { get; set; }
    public string? ToContainerSSCC { get; set; }
    public int? FromContainerUnitId { get; set; }
    public int? ToContainerUnitId { get; set; }
    public TransactionLogContainerUnitResponseDto? FromContainerUnit { get; set; }
    public TransactionLogContainerUnitResponseDto? ToContainerUnit { get; set; }
}
