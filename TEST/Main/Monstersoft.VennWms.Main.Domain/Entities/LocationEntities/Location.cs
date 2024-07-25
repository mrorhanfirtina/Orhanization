using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class Location : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid StorageSystemId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public virtual DepositorCompany? DepositorCompany { get; set; }
    public virtual StorageSystem? StorageSystem { get; set; }
    public virtual LocationLockReason? LocationLockReason { get; set; }
    public virtual LocationPickingType? LocationPickingType { get; set; }
    public virtual LocationDimension? LocationDimension { get; set; }
    public virtual LocationFeature? LocationFeature { get; set; }
    public virtual LocationPriority? LocationPriority { get; set; }
    public virtual LocationCodeFormat? LocationCodeFormat { get; set; }
    public virtual LocationCoordinate? LocationCoordinate { get; set; }
    public virtual ICollection<LocationZone>? LocationZones { get; set; }
    public virtual ICollection<LocationUnitConstraint>? LocationUnitConstraints { get; set; }
    public virtual ICollection<LocationProductCategory>? LocationProductCategories { get; set; }
    public virtual ICollection<LocationProductAbcCategory>? LocationProductAbcCategories { get; set; }
    public virtual ICollection<LocationProductConstraint>? LocationProductConstraints { get; set; }
    public virtual ICollection<LocationDepositor>? LocationDepositors { get; set; }
    public virtual ICollection<LocationProduct>? LocationProducts { get; set; }
    public virtual ICollection<LocationStockAttribute>? LocationStockAttributes { get; set; }
    public virtual ICollection<LocationProductAttribute>? LocationProductAttributes { get; set; }
    public virtual ICollection<BufferLocation>? BufferLocations { get; set; }

    public Location()
    {
        LocationZones = new HashSet<LocationZone>();
        LocationProducts = new HashSet<LocationProduct>();
        LocationStockAttributes = new HashSet<LocationStockAttribute>();
        LocationProductAttributes = new HashSet<LocationProductAttribute>();
        LocationUnitConstraints = new HashSet<LocationUnitConstraint>();
        LocationProductConstraints = new HashSet<LocationProductConstraint>();
        LocationDepositors = new HashSet<LocationDepositor>();
        LocationProductCategories = new HashSet<LocationProductCategory>();
        LocationProductAbcCategories = new HashSet<LocationProductAbcCategory>();
        BufferLocations = new HashSet<BufferLocation>();
    }

    public Location(Guid id,string code, string description, Guid storageSystemId, Guid depositorCompanyId) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        StorageSystemId = storageSystemId;
        DepositorCompanyId = depositorCompanyId;
    }
}
