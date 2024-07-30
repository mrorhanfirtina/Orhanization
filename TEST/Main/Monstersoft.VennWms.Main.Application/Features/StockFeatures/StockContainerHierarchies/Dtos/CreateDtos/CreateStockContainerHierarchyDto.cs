using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Dtos.CreateDtos;

public class CreateStockContainerHierarchyDto
{
    public Guid ParentContainerId { get; set; }
    public Guid ChildContainerId { get; set; }
    public CreateStockContainerDto? ParentContainer { get; set; }
}
