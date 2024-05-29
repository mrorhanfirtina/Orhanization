namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.ResponseDtos;

public class LocationLocationStockAttributeResponseDto
{
    public Guid Id { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
    public bool IsForbid { get; set; }
    public virtual LocationStockAttributeResponseDto? StockAttribute { get; set; }
}
