namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationCoordinates.Dtos.ResponseDtos;

public class LocationCoordinateBuildingDimensionResponseDto
{
    public Guid Id { get; set; }
    public int? LenghtUnitId { get; set; }
    public int? BuildingLevel { get; set; }
    public decimal? Width { get; set; }
    public decimal? Height { get; set; }
    public decimal? Length { get; set; }
    public int? VolumeUnitId { get; set; }
    public decimal? Volume { get; set; }
    public LocationCoordinateVolumeUnitResponseDto? VolumeUnit { get; set; }
    public LocationCoordinateLenghtUnitResponseDto? LenghtUnit { get; set; }
}
