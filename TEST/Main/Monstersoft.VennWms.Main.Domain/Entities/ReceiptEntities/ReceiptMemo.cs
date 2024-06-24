using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

public class ReceiptMemo : Entity<Guid>
{
    public Guid ReceiptId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? EditDate { get; set; }
    public virtual Receipt? Receipt { get; set; }

    public ReceiptMemo()
    {
    }

    public ReceiptMemo(Guid receiptId, string description, string text, DateTime inputDate) : this()
    {
        ReceiptId = receiptId;
        Description = description;
        Text = text;
        InputDate = inputDate;
    }
}
