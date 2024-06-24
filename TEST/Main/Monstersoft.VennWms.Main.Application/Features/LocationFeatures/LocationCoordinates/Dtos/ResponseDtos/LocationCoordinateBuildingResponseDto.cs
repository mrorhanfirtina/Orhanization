namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationCoordinates.Dtos.ResponseDtos;

public class LocationCoordinateBuildingResponseDto
{
    public Guid Id { get; set; }
    public LocationCoordinateBuildingDimensionResponseDto? BuildingDimension { get; set; }
}
