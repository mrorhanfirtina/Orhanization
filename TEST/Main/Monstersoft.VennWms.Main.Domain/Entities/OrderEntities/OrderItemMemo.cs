using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

public class OrderItemMemo : Entity<Guid>
{
    public Guid OrderItemId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? EditDate { get; set; }
    public virtual OrderItem? OrderItem { get; set; }

    public OrderItemMemo()
    {
    }

    public OrderItemMemo(Guid id,Guid orderItemId, string description, string text, DateTime inputDate) : this()
    {
        Id = id;
        OrderItemId = orderItemId;
        Description = description;
        Text = text;
        InputDate = inputDate;
    }
}
