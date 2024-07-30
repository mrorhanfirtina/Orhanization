namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Dtos.UpdateDtos;

public class UpdateStockContainerHierarchySubDto
{
    public Guid ParentContainerId { get; set; }
    public Guid ChildContainerId { get; set; }
}
