using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

public class ReceiptItem : Entity<Guid>
{
    public Guid ReceiptId { get; set; }
    public Guid ProductId { get; set; }
    public int UnitId { get; set; }
    public decimal ExpectedQuantity { get; set; }
    public decimal ActualQuantity { get; set; }
    public int StatusId { get; set; }
    public virtual Receipt? Receipt { get; set; }
    public virtual Product? Product { get; set; }
    public virtual Unit? Unit { get; set;}
    public virtual ICollection<ReceiptItemMemo> ReceiptItemMemos { get; set; }

    public ReceiptItem()
    {
        ReceiptItemMemos = new HashSet<ReceiptItemMemo>();
    }

    public ReceiptItem(Guid id, Guid receiptId, Guid productId, int unitId, decimal expectedQuantity, decimal actualQuantity, int statusId) : this()
    {
        Id = id;
        ReceiptId = receiptId;
        ProductId = productId;
        UnitId = unitId;
        ExpectedQuantity = expectedQuantity;
        ActualQuantity = actualQuantity;
        StatusId = statusId;
    }
}
