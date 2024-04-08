namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LocationDtos;

public class CreateBuildingDimensionDto
{
    public Guid BuildingId { get; set; }
    public int? LenghtUnitId { get; set; }
    public int? BuildingLevel { get; set; }
    public decimal? Width { get; set; }
    public decimal? Height { get; set; }
    public decimal? Length { get; set; }
    public int? VolumeUnitId { get; set; }
    public decimal? Volume { get; set; }
}
