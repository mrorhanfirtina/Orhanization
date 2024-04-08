using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class Building : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public string Province { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string AddressText { get; set; }
    public string ZipCode { get; set; }
    public Guid SiteId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }
    public virtual DepositorCompany DepositorCompany { get; set; }
    public virtual BuildingDimension? BuildingDimension { get; set; }
    public virtual Site? Site { get; set; }
    public virtual ICollection<StorageSystem>? StorageSystems { get; set; }
    public Building()
    {
        StorageSystems = new HashSet<StorageSystem>();
    }

    public Building(Guid id, string code, Guid siteId, string description, string province, string city, string country, string addressText, string zipCode, Guid depositorCompanyId) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        Province = province;
        City = city;
        AddressText = addressText;
        Country = country;
        ZipCode = zipCode;
        SiteId = siteId;
        DepositorCompanyId = depositorCompanyId;
    }
}
