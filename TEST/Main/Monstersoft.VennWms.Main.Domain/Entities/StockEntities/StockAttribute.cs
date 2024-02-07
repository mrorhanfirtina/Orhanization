using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

public class StockAttribute : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public Guid DepositorId { get; set; }
    public bool IsNecessary { get; set; }
    public virtual AttributeInputType? AttributeInputType { get; set; }
    public virtual ICollection<LogStockAttributeValue> LogStockAttributeValues { get; set; }
    public virtual ICollection<OrderItemStockAttrValue> OrderItemStockAttrValues { get; set; }
    public virtual ICollection<ReceiptItmStockAttrValue> ReceiptItmStockAttrValues { get; set; }
    public virtual ICollection<ReturnItmStockAttrValue> ReturnItmStockAttrValues { get; set; }
    public virtual ICollection<StockAttributeValue> StockAttributeValues { get; set; }

    public StockAttribute()
    {
        LogStockAttributeValues = new HashSet<LogStockAttributeValue>();
        OrderItemStockAttrValues = new HashSet<OrderItemStockAttrValue>();
        ReceiptItmStockAttrValues = new HashSet<ReceiptItmStockAttrValue>();
        ReturnItmStockAttrValues = new HashSet<ReturnItmStockAttrValue>();
        StockAttributeValues = new HashSet<StockAttributeValue>();
    }

    public StockAttribute(Guid id, string code, string description, int attributeInputTypeId, Guid depositorId, bool isNecessary) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        AttributeInputTypeId = attributeInputTypeId;
        DepositorId = depositorId;
        IsNecessary = isNecessary;
    }
}
