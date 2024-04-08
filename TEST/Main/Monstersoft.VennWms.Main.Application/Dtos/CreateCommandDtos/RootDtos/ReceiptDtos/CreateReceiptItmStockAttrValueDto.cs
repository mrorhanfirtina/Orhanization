namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ReceiptDtos;

public class CreateReceiptItmStockAttrValueDto
{
    public Guid ReceiptItemId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
}

