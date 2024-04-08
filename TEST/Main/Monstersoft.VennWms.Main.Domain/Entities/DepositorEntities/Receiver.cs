using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

public class Receiver : Entity<Guid>
{
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid CustomerId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public Guid AddressId { get; set; }
    public virtual Address Address { get; set; }
    public virtual Customer Customer { get; set; }
    public virtual DepositorCompany DepositorCompany { get; set; }

    public Receiver()
    {

    }

    public Receiver(Guid id, string code, string name, Guid addressId, Guid customerId, Guid depositorCompanyId) : this()
    {
        Id = id;
        Code = code;
        Name = name;
        AddressId = addressId;
        CustomerId = customerId;
        DepositorCompanyId = depositorCompanyId;
    }
}
