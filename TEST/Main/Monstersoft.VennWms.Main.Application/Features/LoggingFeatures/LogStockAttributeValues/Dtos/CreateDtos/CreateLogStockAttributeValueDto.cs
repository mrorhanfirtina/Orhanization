namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockAttributeValues.Dtos.CreateDtos;

public class CreateLogStockAttributeValueDto
{
    public Guid LogStockId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string FromValue { get; set; }
    public string ToValue { get; set; }
}

