using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

public class ActionParameterCategory : Entity<int>
{
    public string Name { get; set; }
    public virtual ICollection<ActionParameter>? ActionParameters { get; set; }

    public ActionParameterCategory()
    {
        ActionParameters = new HashSet<ActionParameter>();
    }

    public ActionParameterCategory(string name) : this()
    {
        Name = name;
    }
}
