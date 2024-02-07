using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

public class ReceiptItemMemo : Entity<Guid>
{
    public Guid ReceiptItemId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? EditDate { get; set; }
    public virtual ReceiptItem? ReceiptItem { get; set; }

    public ReceiptItemMemo()
    {
    }

    public ReceiptItemMemo(Guid id,Guid receiptItemId, string description, string text, DateTime inputDate) : this()
    {
        Id = id;
        ReceiptItemId = receiptItemId;
        Description = description;
        Text = text;
        InputDate = inputDate;
    }
}
