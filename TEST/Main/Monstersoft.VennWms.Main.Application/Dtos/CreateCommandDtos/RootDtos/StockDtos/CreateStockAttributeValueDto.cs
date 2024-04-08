namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.StockDtos;

public class CreateStockAttributeValueDto
{
    public Guid StockId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
}

