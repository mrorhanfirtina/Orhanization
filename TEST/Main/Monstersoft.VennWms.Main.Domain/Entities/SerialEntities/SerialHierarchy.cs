using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;

public class SerialHierarchy : Entity<Guid>
{
    public Guid RootSerialId { get; set; }
    public Guid ChildSerialId { get; set; }
    public virtual Serial? RootSerial { get; set; }
    public virtual Serial? ChildSerial { get; set; }

    public SerialHierarchy()
    {
    }

    public SerialHierarchy(Guid rootSerialId, Guid childSerialId) : this()
    {
        RootSerialId = rootSerialId;
        ChildSerialId = childSerialId;
    }
}
