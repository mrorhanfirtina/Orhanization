namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.LocationDtos;

public class CreateBuildingDimensionSubDto
{
    public int? LenghtUnitId { get; set; }
    public int? BuildingLevel { get; set; }
    public decimal? Width { get; set; }
    public decimal? Height { get; set; }
    public decimal? Length { get; set; }
    public int? VolumeUnitId { get; set; }
    public decimal? Volume { get; set; }
}
