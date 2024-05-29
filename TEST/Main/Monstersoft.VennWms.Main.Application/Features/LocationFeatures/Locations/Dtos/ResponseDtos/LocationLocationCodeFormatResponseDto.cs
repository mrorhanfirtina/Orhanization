namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.ResponseDtos;

public class LocationLocationCodeFormatResponseDto
{
    public Guid Id { get; set; }
    public int Sector { get; set; }
    public string SectorCode { get; set; }
    public int Column { get; set; }
    public string ColumnCode { get; set; }
    public int Level { get; set; }
    public string LevelCode { get; set; }
    public int? Side { get; set; }
    public string? SideCode { get; set; }
    public int? SubLevel { get; set; }
    public string? SubLevelCode { get; set; }
    public int? SubColumn { get; set; }
    public string? SubColumnCode { get; set; }
    public string? SubPositionCode { get; set; }
}
