using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

public class ReturnItemMemo : Entity<Guid>
{
    public Guid ReturnItemId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? EditDate { get; set; }
    public virtual ReturnItem? ReturnItem { get; set; }

    public ReturnItemMemo()
    {
    }

    public ReturnItemMemo(Guid id, Guid returnItemId, string description, string text, DateTime inputDate) : this()
    {
        Id = id;
        ReturnItemId = returnItemId;
        Description = description;
        Text = text;
        InputDate = inputDate;
    }
}
