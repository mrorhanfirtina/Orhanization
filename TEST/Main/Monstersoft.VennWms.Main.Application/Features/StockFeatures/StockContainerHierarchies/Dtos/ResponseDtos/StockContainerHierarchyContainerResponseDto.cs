namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Dtos.ResponseDtos;

public class StockContainerHierarchyContainerResponseDto
{
    public Guid Id { get; set; }
    public string Sscc { get; set; }
    public int ContainerUnitId { get; set; }
    public StockContainerHierarchyContainerUnitResponseDto? ContainerUnit { get; set; }
    public ICollection<StockContainerHierarchyStockResponseDto>? Stocks { get; set; }
}
