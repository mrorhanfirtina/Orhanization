using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

public class ProgressStatus : Entity<int>
{
    public string Code { get; set; }
    public string Description { get; set; }

    public ProgressStatus()
    {

    }

    public ProgressStatus(int id, string code, string description) : this()
    {
        Id = id;
        Code = code;
        Description = description;
    }
}
