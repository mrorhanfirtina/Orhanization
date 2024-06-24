namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Dtos.ResponseDtos;

public class StockContainersStockReserveReasonResponseDto
{
    public Guid Id { get; set; }
    public Guid ReserveReasonId { get; set; }
    public StockContainersReserveReasonResponseDto? ReserveReason { get; set; }
}