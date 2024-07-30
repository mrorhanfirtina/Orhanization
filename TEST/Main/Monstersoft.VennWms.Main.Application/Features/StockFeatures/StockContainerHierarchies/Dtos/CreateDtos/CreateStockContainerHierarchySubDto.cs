namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Dtos.CreateDtos;

public class CreateStockContainerHierarchySubDto
{
    public Guid ParentContainerId { get; set; }
    public Guid ChildContainerId { get; set; }
}
