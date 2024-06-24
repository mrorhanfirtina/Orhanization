using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

public class Customer : Entity<Guid>
{
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid CompanyId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public Guid AddressId { get; set; }
    public virtual Address? Address { get; set; }
    public virtual DepositorCompany? DepositorCompany { get; set; }
    public virtual Company? Company { get; set; }
    public virtual ICollection<Receiver>? Receivers { get; set; }

    public Customer()
    {
        Receivers = new HashSet<Receiver>();
    }

    public Customer(Guid id, string code, string name, Guid companyId, Guid addressId, Guid depositorCompanyId) : this()
    {
        Id = id;
        Code = code;
        Name = name;
        CompanyId = companyId;
        AddressId = addressId;
        DepositorCompanyId = depositorCompanyId;
    }
}
