namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ReceiptDtos;

public class UpdateReceiptItemSubDto
{
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal ExpectedQuantity { get; set; }
    public decimal ActualQuantity { get; set; }
    public ICollection<UpdateReceiptItemMemoSubDto> ReceiptItemMemos { get; set; }
    public ICollection<UpdateReceiptItmStockAttrValueSubDto> ReceiptItmStockAttrValues { get; set; }
}

