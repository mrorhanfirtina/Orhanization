using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

public class ReceiptItem : Entity<Guid>
{
    public Guid ReceiptId { get; set; }
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal ExpectedQuantity { get; set; }
    public decimal ActualQuantity { get; set; }
    public int StatusId { get; set; }
    public virtual ICollection<ReceiptItemMemo>? ReceiptItemMemos { get; set; }
    public virtual ICollection<ReceiptItmStockAttrValue>? ReceiptItmStockAttrValues { get; set; }
    public virtual Product? Product { get; set; }
    public virtual ItemUnit? ItemUnit { get; set; }
    public virtual Status? Status { get; set; }
    public virtual Receipt? Receipt { get; set; }

    public ReceiptItem()
    {
        ReceiptItemMemos = new HashSet<ReceiptItemMemo>();
        ReceiptItmStockAttrValues = new HashSet<ReceiptItmStockAttrValue>();
    }

    public ReceiptItem(Guid id, Guid receiptId, Guid productId, Guid itemUnitId, decimal expectedQuantity, decimal actualQuantity, int statusId) : this()
    {
        Id = id;
        ReceiptId = receiptId;
        ProductId = productId;
        ItemUnitId = itemUnitId;
        ExpectedQuantity = expectedQuantity;
        ActualQuantity = actualQuantity;
        StatusId = statusId;
    }
}
