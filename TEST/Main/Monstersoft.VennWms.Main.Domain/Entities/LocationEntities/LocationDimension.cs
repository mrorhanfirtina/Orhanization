using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class LocationDimension : Entity<Guid>
{
    public Guid LocationId { get; set; }
    public decimal? Width { get; set; }
    public decimal? Height { get; set; }
    public decimal? Length { get; set; }
    public int? LengthUnitId { get; set; }
    public decimal? Volume { get; set; }
    public int? VolumeUnitId { get; set; }
    public decimal? MaxWeight { get; set; }
    public int? WeightUnitId { get; set; }
    public virtual Unit? LengthUnit { get; set; }
    public virtual Unit? VolumeUnit { get; set; }
    public virtual Unit? WeightUnit { get; set; }

    public LocationDimension()
    {
    }

    public LocationDimension(Guid id, Guid locationId, decimal width, decimal height, decimal length, int lengthUnitId, decimal volume, int volumeUnitId, decimal maxWeight, int weightUnitId) : this()
    {
        Id = id;
        LocationId = locationId;
        Width = width;
        Height = height;
        Length = length;
        LengthUnitId = lengthUnitId;
        Volume = volume;
        VolumeUnitId = volumeUnitId;
        MaxWeight = maxWeight;
        WeightUnitId = weightUnitId;
    }
}
