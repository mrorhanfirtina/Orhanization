namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Commands.Update;

public class UpdatedStockContainerResponse
{
    public Guid Id { get; set; }
    public string Sscc { get; set; }
    public Guid ContainerUnitId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}
