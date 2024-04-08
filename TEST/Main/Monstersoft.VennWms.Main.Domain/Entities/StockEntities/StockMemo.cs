using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

public class StockMemo : Entity<Guid>
{
    public Guid StockId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? EditDate { get; set; }

    public StockMemo()
    {
    }

    public StockMemo(Guid id, Guid stockId, string description, string text, DateTime inputDate) : this()
    {
        Id = id;
        StockId = stockId;
        Description = description;
        Text = text;
        InputDate = inputDate;
    }
}
