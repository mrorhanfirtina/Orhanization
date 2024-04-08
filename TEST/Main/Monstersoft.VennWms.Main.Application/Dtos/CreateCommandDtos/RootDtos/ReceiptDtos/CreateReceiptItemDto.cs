using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ReceiptDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ReceiptDtos;

public class CreateReceiptItemDto
{
    public Guid ReceiptId { get; set; }
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal ExpectedQuantity { get; set; }
    public decimal ActualQuantity { get; set; }
    public int StatusId { get; set; }
    public ICollection<CreateReceiptItemMemoSubDto> ReceiptItemMemos { get; set; }
    public ICollection<CreateReceiptItmStockAttrValueSubDto> ReceiptItmStockAttrValues { get; set; }
}

