using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

public class Company : Entity<Guid>
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public string? TaxOffice { get; set; }
    public string? TaxNumber { get; set; }
    public string? PhoneNumber { get; set; }
    public string? FaxNumber { get; set; }
    public Guid AddressId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public virtual Address? Address { get; set; }
    public virtual DepositorCompany DepositorCompany { get; set; }

    public Company()
    {

    }

    public Company(Guid id, string code, string name, Guid addressId, Guid depositorCompanyId) : this()
    {
        Id = id;
        Code = code;
        Name = name;
        AddressId = addressId;
        DepositorCompanyId = depositorCompanyId;
    }
}
