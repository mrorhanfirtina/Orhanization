using Orhanization.Core.Persistence.Repositories;
using Orhanization.Core.Security.Entities;

namespace Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

public class ActionParameterUser : Entity<Guid>
{
    public int ActionParameterId { get; set; }
    public int UserId { get; set; }
    public string Value { get; set; }
    public ActionParameter? ActionParameter { get; set; }
    public User? User { get; set; }

    public ActionParameterUser()
    {
    }

    public ActionParameterUser(int actionParameterId, int userId, string value): this()
    {
        ActionParameterId = actionParameterId;
        UserId = userId;
        Value = value;
    }
}
