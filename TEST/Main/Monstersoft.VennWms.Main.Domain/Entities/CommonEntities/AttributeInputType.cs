using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

public class AttributeInputType : Entity<int>
{
    public string Description { get; set; }

    public AttributeInputType()
    {

    }

    public AttributeInputType(string description) : this()
    {
        Description = description;
    }
}
