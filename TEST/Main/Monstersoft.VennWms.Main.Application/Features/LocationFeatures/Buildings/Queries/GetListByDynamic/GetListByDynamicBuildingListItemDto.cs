using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Queries.GetListByDynamic;

public class GetListByDynamicBuildingListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }

    public string Description { get; set; }
    public string Province { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string AddressText { get; set; }
    public string ZipCode { get; set; }
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public BuildingSiteResponseDto? Site { get; set; }
    public BuildingDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public BuildingBuildingDimensionResponseDto? BuildingDimension { get; set; }
    public ICollection<BuildingStorageSystemResponseDto>? StorageSystems { get; set; }
    public ICollection<BuildingZoneResponseDto>? Zones { get; set; }

}

