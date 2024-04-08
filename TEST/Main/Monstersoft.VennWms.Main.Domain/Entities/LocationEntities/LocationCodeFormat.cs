using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class LocationCodeFormat : Entity<Guid>
{
    public Guid LocationId { get; set; }
    public int Sector { get; set; }
    public string SectorCode { get; set; }
    public int Column { get; set; }
    public string ColumnCode { get; set; }
    public int Level { get; set; }
    public string LevelCode { get; set; }
    public int Side { get; set; }
    public string SideCode { get; set; }
    public int SubLevel { get; set; }
    public string SubLevelCode { get; set; }
    public int SubColumn { get; set; }
    public string SubColumnCode { get; set; }
    public string SubPositionCode { get; set; }

    public LocationCodeFormat()
    {
    }

    public LocationCodeFormat(Guid id, Guid locationId, int sector, string sectorCode, int column, string columnCode, int level, string levelCode, int side, string sideCode, int subLevel, string subLevelCode, int subColumn, string subColumnCode, string subPositionCode) : this()
    {
        Id = id;
        LocationId = locationId;
        Sector = sector;
        SectorCode = sectorCode;
        Column = column;
        ColumnCode = columnCode;
        Level = level;
        LevelCode = levelCode;
        Side = side;
        SideCode = sideCode;
        SubLevel = subLevel;
        SubLevelCode = subLevelCode;
        SubColumn = subColumn;
        SubColumnCode = subColumnCode;
        SubPositionCode = subPositionCode;
    }
}
