using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Queries.GetListByDynamic;

public class GetListByDynamicStockContainerHierarchyListItemDto
{
    public Guid Id { get; set; }
    public Guid ParentContainerId { get; set; }
    public Guid ChildContainerId { get; set; }
    public StockContainerHierarchyContainerResponseDto? ParentContainer { get; set; }
    public StockContainerHierarchyContainerResponseDto? ChildContainer { get; set; }
}
