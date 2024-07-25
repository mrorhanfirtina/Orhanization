namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Dtos.UpdateDtos;

public class UpdateStockContainerHierarchyDto
{
    public Guid Id { get; set; }
    public Guid ParentContainerId { get; set; }
    public Guid ChildContainerId { get; set; }
}
