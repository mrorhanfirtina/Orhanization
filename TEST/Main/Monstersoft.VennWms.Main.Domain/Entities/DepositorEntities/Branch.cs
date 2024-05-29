using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

public class Branch : Entity<Guid>
{
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid DistributorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public Guid AddressId { get; set; }
    public virtual Address? Address { get; set; }
    public virtual DepositorCompany? DepositorCompany { get; set; }
    public virtual Distributor? Distributor { get; set; }

    public Branch()
    {

    }

    public Branch(Guid id, string code, string name, Guid addressId, Guid distributorId, Guid depositorCompanyId) : this()
    {
        Id = id;
        Code = code;
        Name = name;
        AddressId = addressId;
        DistributorId = distributorId;
        DepositorCompanyId = depositorCompanyId;
    }
}
