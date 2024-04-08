namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Commands.Create;

public class CreatedStockContainerResponse
{
    public Guid Id { get; set; }
    public string Sscc { get; set; }
    public Guid ContainerUnitId { get; set; }
    public DateTime CreatedDate { get; set; }

}
