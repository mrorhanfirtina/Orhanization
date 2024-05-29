namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Dtos.ResponseDtos;

public class LogStockLogStockContainerResponseDto
{
    public Guid Id { get; set; }
    public Guid? FromContainerId { get; set; }
    public Guid? ToContainerId { get; set; }
    public string? FromContainerSSCC { get; set; }
    public string? ToContainerSSCC { get; set; }
    public int? FromContainerUnitId { get; set; }
    public int? ToContainerUnitId { get; set; }
    public LogStockContainerUnitResponseDto? FromContainerUnit { get; set; }
    public LogStockContainerUnitResponseDto? ToContainerUnit { get; set; }
}
