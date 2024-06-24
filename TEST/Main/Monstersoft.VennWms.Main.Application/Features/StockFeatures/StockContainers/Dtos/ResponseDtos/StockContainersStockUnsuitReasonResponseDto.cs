namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Dtos.ResponseDtos;

public class StockContainersStockUnsuitReasonResponseDto
{
    public Guid Id { get; set; }
    public Guid UnsuitReasonId { get; set; }
    public StockContainersUnsuitReasonResponseDto? ReserveReason { get; set; }
}