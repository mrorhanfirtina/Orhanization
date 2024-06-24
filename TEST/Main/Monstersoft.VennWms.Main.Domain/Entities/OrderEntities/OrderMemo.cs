using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

public class OrderMemo : Entity<Guid>
{
    public Guid OrderId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? EditDate { get; set; }
    public virtual Order? Order { get; set; }

    public OrderMemo()
    {
    }

    public OrderMemo(Guid orderId, string description, string text, DateTime inputDate) : this()
    {
        OrderId = orderId;
        Description = description;
        Text = text;
        InputDate = inputDate;
    }
}
