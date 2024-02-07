using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

public class ShipmentType : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsCodeGenerate { get; set; }
    public string Format { get; set; }
    public int Counter { get; set; }
    public Guid DepositorId { get; set; }
    public virtual ICollection<Shipment> Shipments { get; set; }

    public ShipmentType()
    {
        Shipments = new HashSet<Shipment>();
    }

    public ShipmentType(Guid id, string code, string description, bool isCodeGenerate, string format, int counter, Guid depositorId) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        IsCodeGenerate = isCodeGenerate;
        Format = format;
        Counter = counter;
        DepositorId = depositorId;
    }
}
