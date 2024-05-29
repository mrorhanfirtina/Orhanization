namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockAttributeValues.Dtos.UpdateDtos;

public class UpdateLogStockAttributeValueDto
{
    public Guid Id { get; set; }
    public Guid LogStockId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string FromValue { get; set; }
    public string ToValue { get; set; }
}

