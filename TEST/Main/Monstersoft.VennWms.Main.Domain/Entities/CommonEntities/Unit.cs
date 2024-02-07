using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

public class Unit : Entity<int>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid DepositorId { get; set; }
    public virtual ICollection<ReceiptItem> ReceiptItems { get; set; }
    public virtual ICollection<ReturnItem> ReturnItems { get; set; }
    public virtual ICollection<Stock> Stocks { get; set; }

    public Unit()
    {
        ReceiptItems = new HashSet<ReceiptItem>();
        ReturnItems = new HashSet<ReturnItem>();
        Stocks = new HashSet<Stock>();
    }

    public Unit(int id, string code, string description, Guid depositorId) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        DepositorId = depositorId;
    }
}
