namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Dtos.CreateDtos;

public class CreateLocationStockAttributeSubDto
{
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
    public bool IsForbid { get; set; }
}
