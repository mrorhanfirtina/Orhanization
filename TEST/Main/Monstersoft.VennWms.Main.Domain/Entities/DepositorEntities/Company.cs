using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public virtual ICollection<Customer> Customers { get; set; }
    public virtual ICollection<Disturbitor> Disturbitors { get; set; }
    public virtual ICollection<Supplier> Suppliers { get; set; }

    public Company()
    {
        Customers = new HashSet<Customer>();
        Disturbitors = new HashSet<Disturbitor>();
        Suppliers = new HashSet<Supplier>();
    }

    public Company(Guid id, string code, string name) : this()
    {
        Id = id;
        Code = code;
        Name = name;
    }
}
