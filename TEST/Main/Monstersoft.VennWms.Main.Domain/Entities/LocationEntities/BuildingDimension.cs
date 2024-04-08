using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class BuildingDimension : Entity<Guid>
{
    public Guid BuildingId { get; set; }
    public int? LenghtUnitId { get; set; }
    public int? BuildingLevel { get; set; }
    public decimal? Width { get; set; }
    public decimal? Height { get; set; }
    public decimal? Length { get; set; }
    public int? VolumeUnitId { get; set; }
    public decimal? Volume { get; set; }
    public virtual Unit? LenghtUnit { get; set; }
    public virtual Unit? VolumeUnit { get; set; }

    public BuildingDimension()
    {
    }

    public BuildingDimension(Guid id, Guid buildingId, int lenghtUnitId, int buildingLevel, decimal width, decimal height, decimal length, int volumeUnitId, decimal volume) : this()
    {
        Id = id;
        BuildingId = buildingId;
        LenghtUnitId = lenghtUnitId;
        BuildingLevel = buildingLevel;
        Width = width;
        Height = height;
        Length = length;
        VolumeUnitId = volumeUnitId;
        Volume = volume;
    }
}
