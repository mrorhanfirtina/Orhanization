namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LoggingDtos;

public class UpdateLogStockAttributeValueDto
{
    public Guid Id { get; set; }
    public Guid LogStockId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string FromValue { get; set; }
    public string ToValue { get; set; }
}

