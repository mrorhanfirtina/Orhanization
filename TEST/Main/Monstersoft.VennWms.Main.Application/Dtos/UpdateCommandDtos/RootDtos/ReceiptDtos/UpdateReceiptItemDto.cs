using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ReceiptDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ReceiptDtos;

public class UpdateReceiptItemDto
{
    public Guid Id { get; set; }
    public Guid ReceiptId { get; set; }
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal ExpectedQuantity { get; set; }
    public decimal ActualQuantity { get; set; }
    public int StatusId { get; set; }
    public ICollection<UpdateReceiptItemMemoSubDto> ReceiptItemMemos { get; set; }
    public ICollection<UpdateReceiptItmStockAttrValueSubDto> ReceiptItmStockAttrValues { get; set; }
}

