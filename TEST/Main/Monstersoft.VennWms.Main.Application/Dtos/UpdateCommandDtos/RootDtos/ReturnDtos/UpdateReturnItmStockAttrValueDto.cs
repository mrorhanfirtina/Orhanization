namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ReturnDtos;

public class UpdateReturnItmStockAttrValueDto
{
    public Guid Id { get; set; }
    public Guid ReturnItemId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
}

