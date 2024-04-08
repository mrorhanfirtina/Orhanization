using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

public class PickingType : Entity<int>
{
    public string Code { get; set; }
    public string Description { get; set; }

    public PickingType()
    {
    }

    public PickingType(int id, string code, string description) : this()
    {
        Id = id;
        Code = code;
        Description = description;
    }
}
