using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

public class Product : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public string? AlternativeCode { get; set; }
    public Guid DepositorId { get; set; }
    public virtual ICollection<ProductAttributeValue> ProductAttributeValues { get; set; }
    public virtual ICollection<OrderItem> OrderItems { get; set; }
    public virtual ICollection<LogStock> LogStocks { get; set; }
    public virtual ICollection<ReceiptItem> ReceiptItems { get; set; }
    public virtual ICollection<ReturnItem> ReturnItems { get; set; }
    public virtual ICollection<Stock> Stocks { get; set; }

    public Product()
    {
        ProductAttributeValues = new HashSet<ProductAttributeValue>();
        LogStocks = new HashSet<LogStock>();
        OrderItems = new HashSet<OrderItem>();
        ReceiptItems = new HashSet<ReceiptItem>();
        ReturnItems = new HashSet<ReturnItem>();
        Stocks = new HashSet<Stock>();
    }

    public Product(Guid id, string code, string description, string alternativeCode) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        AlternativeCode = alternativeCode;
    }
}
