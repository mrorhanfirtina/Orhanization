namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Dtos.CreateDtos;

public class CreateStockAttributeValueDto
{
    public Guid StockId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
}

