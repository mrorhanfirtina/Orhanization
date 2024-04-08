namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Commands.Create;

public class CreatedLocationStockAttributeResponse
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public Guid StockAttributeId { get; set; }
    public bool IsForbid { get; set; }
    public DateTime CreatedDate { get; set; }

}

