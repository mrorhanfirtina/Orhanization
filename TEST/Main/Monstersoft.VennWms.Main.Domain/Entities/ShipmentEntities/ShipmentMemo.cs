using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

public class ShipmentMemo : Entity<Guid>
{
    public Guid ShipmentId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? EditDate { get; set; }
    public virtual Shipment? Shipment { get; set; }

    public ShipmentMemo()
    {
    }

    public ShipmentMemo(Guid id, Guid shipmentId, string description, string text, DateTime inputDate) : this()
    {
        Id = id;
        ShipmentId = shipmentId;
        Description = description;
        Text = text;
        InputDate = inputDate;
    }
}
