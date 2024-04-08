using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

public class DepositorCompany : Entity<Guid>
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public string? TaxOffice { get; set; }
    public string? TaxNumber { get; set; }
    public string? PhoneNumber { get; set; }
    public string? FaxNumber { get; set; }
    public Guid AddressId { get; set; }
    public virtual Address Address { get; set; }
    public DepositorCompany()
    {
    }

    public DepositorCompany(Guid id, string code, string name) : this()
    {
        Id = id;
        Code = code;
        Name = name;
    }
}
