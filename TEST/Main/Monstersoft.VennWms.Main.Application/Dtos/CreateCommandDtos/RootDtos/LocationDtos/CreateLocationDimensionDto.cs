namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LocationDtos;

public class CreateLocationDimensionDto
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
}
