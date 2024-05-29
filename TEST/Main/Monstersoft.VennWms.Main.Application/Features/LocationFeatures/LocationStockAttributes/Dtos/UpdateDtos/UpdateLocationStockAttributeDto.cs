namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Dtos.UpdateDtos;

public class UpdateLocationStockAttributeDto
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
    public bool IsForbid { get; set; }
}

