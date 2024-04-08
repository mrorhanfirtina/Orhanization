using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

public class ReturnMemo : Entity<Guid>
{
    public Guid ReturnId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? EditDate { get; set; }

    public ReturnMemo()
    {
    }

    public ReturnMemo(Guid id, Guid returnId, string description, string text, DateTime inputDate) : this()
    {
        Id = id;
        ReturnId = returnId;
        Description = description;
        Text = text;
        InputDate = inputDate;
    }
}
