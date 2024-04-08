using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.LocationDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LocationDtos;

public class UpdateBuildingDto
{ 
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid SiteId { get; set; }
    public string Description { get; set; }
    public string Province { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string AddressText { get; set; }
    public string ZipCode { get; set; }
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }
    public virtual UpdateBuildingDimensionSubDto? BuildingDimension { get; set; }
}

