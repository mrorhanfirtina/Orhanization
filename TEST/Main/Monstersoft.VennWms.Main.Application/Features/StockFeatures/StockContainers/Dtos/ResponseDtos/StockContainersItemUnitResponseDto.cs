namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Dtos.ResponseDtos;

public class StockContainersItemUnitResponseDto
{
    public Guid Id { get; set; }
    public int UnitId { get; set; }
    public bool IsConsumerUnit { get; set; }
    public StockContainersUnitResponseDto? Unit { get; set; }
}