using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Queries.GetListByDynamic;

public class GetListByDynamicStockContainerListItemDto
{
    public Guid Id { get; set; }
    public string Sscc { get; set; }
    public int ContainerUnitId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public StockContainersContainerUnitResponseDto? ContainerUnit { get; set; }
    public ICollection<StockContainersStockResponseDto>? Stocks { get; set; }
}
