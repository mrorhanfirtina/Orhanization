using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Queries.GetListByDynamic;

public class GetListByDynamicLocationZoneListItemDto
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public Guid ZoneId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public LocationZoneLocationResponseDto? Location { get; set; }
    public LocationZoneZoneResponseDto? Zone { get; set; }
}

