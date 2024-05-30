using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

public class ReturnAttributeValue : Entity<Guid>
{
    public Guid ReturnId { get; set; }
    public Guid ReturnAttributeId { get; set; }
    public string Value { get; set; }
    public virtual ReturnAttribute? ReturnAttribute { get; set; }
    public virtual Return? Return { get; set; }

    public ReturnAttributeValue()
    {
    }

    public ReturnAttributeValue(Guid id, Guid returnId, Guid returnAttributeId, string value) : this()
    {
        Id = id;
        ReturnId = returnId;
        ReturnAttributeId = returnAttributeId;
        Value = value;
    }
}
