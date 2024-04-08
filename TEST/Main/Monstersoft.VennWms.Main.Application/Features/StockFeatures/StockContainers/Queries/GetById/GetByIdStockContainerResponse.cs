namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Queries.GetById;

public class GetByIdStockContainerResponse
{
    public Guid Id { get; set; }
    public string Sscc { get; set; }
    public Guid ContainerUnitId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}
