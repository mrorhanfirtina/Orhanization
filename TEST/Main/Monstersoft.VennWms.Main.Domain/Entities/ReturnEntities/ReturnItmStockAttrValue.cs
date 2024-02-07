using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

public class ReturnItmStockAttrValue : Entity<Guid>
{
    public Guid ReturnItemId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
    public virtual ReturnItem? ReturnItem { get; set; }
    public virtual StockAttribute? StockAttribute { get; set; }

    public ReturnItmStockAttrValue()
    {
    }

    public ReturnItmStockAttrValue(Guid id, Guid returnItemId, Guid stockAttributeId, string value) : this()
    {
        Id = id;
        ReturnItemId = returnItemId;
        StockAttributeId = stockAttributeId;
        Value = value;
    }
}
