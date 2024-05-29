namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.ResponseDtos;

public class LocationBuildingDimensionResponseDto
{
    public Guid Id { get; set; }
    public int? LenghtUnitId { get; set; }
    public int? BuildingLevel { get; set; }
    public decimal? Width { get; set; }
    public decimal? Height { get; set; }
    public decimal? Length { get; set; }
    public int? VolumeUnitId { get; set; }
    public decimal? Volume { get; set; }
    public LocationVolumeUnitResponseDto? VolumeUnit { get; set; }
    public LocationLengthUnitResponseDto? LenghtUnit { get; set; }
}
