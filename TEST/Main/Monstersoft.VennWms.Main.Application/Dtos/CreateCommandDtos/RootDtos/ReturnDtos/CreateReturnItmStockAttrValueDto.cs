namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ReturnDtos;

public class CreateReturnItmStockAttrValueDto
{
    public Guid ReturnItemId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
}

