using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.POEntities;

public class PoMemo : Entity<Guid>
{
    public Guid PurchaseOrderId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? EditDate { get; set; }
    public virtual PurchaseOrder? PurchaseOrder { get; set; }

    public PoMemo()
    {
    }

    public PoMemo(Guid id,Guid purchaseOrderId, string description, string text, DateTime inputDate, DateTime? editDate) : this()
    {
        Id = id;
        PurchaseOrderId = purchaseOrderId;
        Description = description;
        Text = text;
        InputDate = inputDate;
        EditDate = editDate;
    }
}
