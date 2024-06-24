using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Dtos.UpdateDtos;

public class UpdateReceiptItemSubDto
{
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal ExpectedQuantity { get; set; }
    public decimal ActualQuantity { get; set; }
    public ICollection<UpdateReceiptItemMemoSubDto> ReceiptItemMemos { get; set; }
    public ICollection<UpdateReceiptItmStockAttrValueSubDto> ReceiptItmStockAttrValues { get; set; }
}

