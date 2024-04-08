namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ReceiptDtos;

public class CreateReceiptItemSubDto
{
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal ExpectedQuantity { get; set; }
    public decimal ActualQuantity { get; set; }
    public ICollection<CreateReceiptItemMemoSubDto> ReceiptItemMemos { get; set; }
    public ICollection<CreateReceiptItmStockAttrValueSubDto> ReceiptItmStockAttrValues { get; set; }
}

