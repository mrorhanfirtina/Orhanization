using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

public class ReceiptItmStockAttrValue : Entity<Guid>
{
    public Guid ReceiptItemId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
    public virtual ReceiptItem? ReceiptItem { get; set; }
    public virtual StockAttribute? StockAttribute { get; set; }

    public ReceiptItmStockAttrValue()
    {
    }

    public ReceiptItmStockAttrValue(Guid id, Guid receiptItemId, Guid stockAttributeId, string value) : this()
    {
        Id = id;
        ReceiptItemId = receiptItemId;
        StockAttributeId = stockAttributeId;
        Value = value;
    }
}
