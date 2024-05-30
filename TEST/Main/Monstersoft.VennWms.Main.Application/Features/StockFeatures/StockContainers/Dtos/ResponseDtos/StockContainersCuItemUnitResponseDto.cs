namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Dtos.ResponseDtos;

public class StockContainersCuItemUnitResponseDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public int UnitId { get; set; }
    public StockContainersUnitResponseDto? Unit { get; set; }
}