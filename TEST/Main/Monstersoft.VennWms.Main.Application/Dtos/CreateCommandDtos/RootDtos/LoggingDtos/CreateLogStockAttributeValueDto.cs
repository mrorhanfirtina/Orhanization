namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LoggingDtos;

public class CreateLogStockAttributeValueDto
{
    public Guid LogStockId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string FromValue { get; set; }
    public string ToValue { get; set; }
}

