using Orhanization.Core.Persistence.Repositories;
using Orhanization.Core.Security.Entities;

namespace Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

public class UserDepositor : Entity<Guid>
{
    public Guid DepositorId { get; set; }
    public int UserId { get; set; }
    public virtual Depositor Depositor { get; set; }
    public virtual User User { get; set; }

    public UserDepositor()
    {
    }

    public UserDepositor(Guid id, Guid depositorId, int userId) : this()
    {
        Id = id;
        DepositorId = depositorId;
        UserId = userId;
    }
}
