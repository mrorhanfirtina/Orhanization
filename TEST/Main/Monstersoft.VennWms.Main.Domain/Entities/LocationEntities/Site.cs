using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class Site : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public virtual DepositorCompany DepositorCompany { get; set; }
    public virtual ICollection<SiteDepositor> SiteDepositors { get; set; }
    public Site()
    {
        SiteDepositors = new HashSet<SiteDepositor>();
    }

    public Site(Guid id,string code, string description, Guid depositorCompanyId):this()
    {
        Id = id;
        Code = code;
        Description = description;
        DepositorCompanyId = depositorCompanyId;
    }
}
