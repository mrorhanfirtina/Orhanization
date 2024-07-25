using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

public class ActionParameter : Entity<int>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string DefaultValue { get; set; }
    public int CategoryId { get; set; }
    public ActionParameterCategory? ActionParameterCategory { get; set; }
    public virtual ICollection<ActionParameterUser>? ActionParameterUsers { get; set; }
    public virtual ICollection<ActionParameterDepositor>? ActionParameterDepositors { get; set; }
    public virtual ICollection<ActionParameterDefault>? ActionParameterDefaults { get; set; }

    public ActionParameter()
    {
        ActionParameterUsers = new HashSet<ActionParameterUser>();
        ActionParameterDepositors = new HashSet<ActionParameterDepositor>();
        ActionParameterDefaults = new HashSet<ActionParameterDefault>();
    }

    public ActionParameter(string name, string description, string defaultValue, int categoryId) : this()
    {
        Name = name;
        Description = description;
        DefaultValue = defaultValue;
        CategoryId = categoryId;
    }
}
