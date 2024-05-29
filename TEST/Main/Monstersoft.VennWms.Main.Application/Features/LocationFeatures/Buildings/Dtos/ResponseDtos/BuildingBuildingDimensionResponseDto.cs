namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Dtos.ResponseDtos;

public class BuildingBuildingDimensionResponseDto
{
    public Guid Id { get; set; }
    public int? LenghtUnitId { get; set; }
    public int? BuildingLevel { get; set; }
    public decimal? Width { get; set; }
    public decimal? Height { get; set; }
    public decimal? Length { get; set; }
    public int? VolumeUnitId { get; set; }
    public decimal? Volume { get; set; }
    public BuildingVolumeUnitResponseDto? VolumeUnit { get; set; }
    public BuildingLenghtUnitResponseDto? LenghtUnit { get; set; }
}
