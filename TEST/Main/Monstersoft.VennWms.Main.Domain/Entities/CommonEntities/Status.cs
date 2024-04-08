using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

public class Status : Entity<int>
{
    public string Code { get; set; }
    public string Description { get; set; }

    public Status()
    {

    }

    public Status(int id, string code, string description) : this()
    {
        Id = id;
        Code = code;
        Description = description;
    }
}
