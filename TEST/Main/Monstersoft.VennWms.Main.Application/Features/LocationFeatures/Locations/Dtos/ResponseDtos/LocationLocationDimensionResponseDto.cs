namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.ResponseDtos;

public class LocationLocationDimensionResponseDto
{
    public Guid Id { get; set; }
    public decimal? Width { get; set; }
    public decimal? Height { get; set; }
    public decimal? Length { get; set; }
    public int? LengthUnitId { get; set; }
    public decimal? Volume { get; set; }
    public int? VolumeUnitId { get; set; }
    public decimal? MaxWeight { get; set; }
    public int? WeightUnitId { get; set; }
    public virtual LocationUnitResponseDto? LengthUnit { get; set; }
    public virtual LocationUnitResponseDto? VolumeUnit { get; set; }
    public virtual LocationUnitResponseDto? WeightUnit { get; set; }
}
