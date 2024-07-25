namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Dtos.ResponseDtos;

public class StockContainerHierarchyItemUnitResponseDto
{
    public Guid Id { get; set; }
    public int UnitId { get; set; }
    public StockContainerHierarchyUnitResponseDto? Unit { get; set; }
}
