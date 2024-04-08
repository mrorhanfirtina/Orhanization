namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.StockDtos;

public class UpdateStockAttributeValueDto
{
    public Guid Id { get; set; }
    public Guid StockId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
}

