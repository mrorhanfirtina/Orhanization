using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

public class AttributeInputType : Entity<int>
{
    public string Description { get; set; }
    public virtual ICollection<ProductAttribute> ProductAttributes { get; set; }
    public virtual ICollection<OrderAttribute> OrderAttributes { get; set; }
    public virtual ICollection<PoAttribute> PoAttributes { get; set; }
    public virtual ICollection<ReceiptAttribute> ReceiptAttributes { get; set; }
    public virtual ICollection<ReturnAttribute> ReturnAttributes { get; set; }
    public virtual ICollection<ShipmentAttribute> ShipmentAttributes { get; set; }
    public virtual ICollection<StockAttribute> StockAttributes { get; set; }

    public AttributeInputType()
    {
        ProductAttributes = new HashSet<ProductAttribute>();
        OrderAttributes = new HashSet<OrderAttribute>();
        PoAttributes = new HashSet<PoAttribute>();
        ReceiptAttributes = new HashSet<ReceiptAttribute>();
        ReturnAttributes = new HashSet<ReturnAttribute>();
        ShipmentAttributes = new HashSet<ShipmentAttribute>();
        StockAttributes = new HashSet<StockAttribute>();
    }

    public AttributeInputType(string description):this()
    {
        Description = description;
    }
}
