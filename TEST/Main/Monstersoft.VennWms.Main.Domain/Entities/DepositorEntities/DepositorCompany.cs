using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public virtual ICollection<Depositor> Depositors { get; set; }

    public DepositorCompany()
    {
        Depositors = new HashSet<Depositor>();
    }

    public DepositorCompany(Guid id, string code, string name) : this()
    {
        Id = id;
        Code = code;
        Name = name;
    }
}
