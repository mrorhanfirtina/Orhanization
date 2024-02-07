using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

public class StockAttributeValue : Entity<Guid>
{
    public Guid StockId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
    public virtual Stock? Stock { get; set; }
    public virtual StockAttribute? StockAttribute { get; set; }

    public StockAttributeValue()
    {
    }

    public StockAttributeValue(Guid id, Guid stockId, Guid stockAttributeId, string value):this()
    {
        Id = id;
        StockId = stockId;
        StockAttributeId = stockAttributeId;
        Value = value;
    }
}
