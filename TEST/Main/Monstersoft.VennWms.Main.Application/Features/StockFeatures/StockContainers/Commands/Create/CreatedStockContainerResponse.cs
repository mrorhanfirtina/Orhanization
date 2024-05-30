using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Commands.Create;

public class CreatedStockContainerResponse
{
    public Guid Id { get; set; }
    public string Sscc { get; set; }
    public int ContainerUnitId { get; set; }
    public DateTime CreatedDate { get; set; }
    public StockContainersContainerUnitResponseDto? ContainerUnit { get; set; }
    public ICollection<StockContainersStockResponseDto>? Stocks { get; set; }
}
