using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

public class Address : Entity<Guid>
{
    public string Description { get; set; }
    public string Province { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string AddressText { get; set; }
    public string ZipCode { get; set; }
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }

    public Address()
    {
    }
    public Address(Guid id, string description, string province, string city, string country, string address, string zipCode) : this()
    {
        Id = id;
        Description = description;
        Province = province;
        City = city;
        Country = country;
        AddressText = address;
        ZipCode = zipCode;
    }

}
