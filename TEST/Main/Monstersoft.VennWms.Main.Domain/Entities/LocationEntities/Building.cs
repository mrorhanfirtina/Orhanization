using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class Building : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public string Province { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string Address { get; set; }
    public string ZipCode { get; set; }
    public virtual ICollection<Site> Sites { get; set; }
    public virtual ICollection<Branch> Branches { get; set; }
    public virtual ICollection<Customer> Customers { get; set; }
    public virtual ICollection<Depositor> Depositors { get; set; }
    public virtual ICollection<Disturbitor> Disturbitors { get; set; }
    public virtual ICollection<Receiver> Receivers { get; set; }
    public virtual ICollection<Supplier> Suppliers { get; set; }

    public Building()
    {
        Sites = new HashSet<Site>();
        Branches = new HashSet<Branch>();
        Customers = new HashSet<Customer>();
        Depositors = new HashSet<Depositor>();
        Disturbitors = new HashSet<Disturbitor>();
        Receivers = new HashSet<Receiver>();
        Suppliers = new HashSet<Supplier>();
    }

    public Building(Guid id, string code, string description, string province, string city, string country, string address, string zipCode) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        Province = province;
        City = city;
        Country = country;
        Address = address;
        ZipCode = zipCode;
    }
}
