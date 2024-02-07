using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.POEntities;

public class PurchaseOrder : Entity<Guid>
{
    public string Code { get; set; }
    public Guid SupplierId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid PoTypeId { get; set; }
    public int StatusId { get; set; }
    public virtual Supplier? Supplier { get; set; }
    public virtual PoType? PoType { get; set; }
    public virtual ICollection<PoAttributeValue> PoAttributeValues { get; set; }
    public virtual ICollection<PoMemo> PoMemos { get; set; }
    public virtual ICollection<Receipt> Receipts { get; set; }

    public PurchaseOrder()
    {
        PoAttributeValues = new HashSet<PoAttributeValue>();
        PoMemos = new HashSet<PoMemo>();
        Receipts = new HashSet<Receipt>();
    }

    public PurchaseOrder(Guid id, string code, Guid supplierId, Guid depositorId,Guid poTypeId, int statusId) : this()
    {
        Id = id;
        Code = code;
        SupplierId = supplierId;
        DepositorId = depositorId;
        PoTypeId = poTypeId;
        StatusId = statusId;
    }
}
