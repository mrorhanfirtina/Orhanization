using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

public class AbcCategoryList : Entity<int>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public int Priority { get; set; }

    public AbcCategoryList()
    {
    }

    public AbcCategoryList(int id, string code, string description, int priority) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        Priority = priority;
    }
}
