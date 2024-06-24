using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class LocationPriority : Entity<Guid>
{
    public Guid LocationId { get; set; }
    public int InboundPriority { get; set; }
    public int OutboundPriority { get; set; }
    public Location? Location { get; set; }

    public LocationPriority()
    {
    }

    public LocationPriority(Guid id, Guid locationId, int inboundPriority, int outboundPriority) : this()
    {
        Id = id;
        LocationId = locationId;
        InboundPriority = inboundPriority;
        OutboundPriority = outboundPriority;
    }
}
