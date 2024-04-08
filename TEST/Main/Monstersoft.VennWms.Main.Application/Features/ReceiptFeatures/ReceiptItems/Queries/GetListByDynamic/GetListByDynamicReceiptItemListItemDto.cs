using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Queries.GetListByDynamic;

public class GetListByDynamicReceiptItemListItemDto
{
    public Guid Id { get; set; }
    public Guid ReceiptId { get; set; }
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal ExpectedQuantity { get; set; }
    public decimal ActualQuantity { get; set; }
    public int StatusId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public Receipt Receipt { get; set; }
    public ICollection<ReceiptItemMemo> ReceiptItemMemos { get; set; }
    public ICollection<ReceiptItmStockAttrValue> ReceiptItmStockAttrValues { get; set; }

}
