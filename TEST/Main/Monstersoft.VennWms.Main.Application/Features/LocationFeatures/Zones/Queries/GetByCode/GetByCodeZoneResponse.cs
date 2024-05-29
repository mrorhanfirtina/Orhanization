using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Queries.GetByCode;

public class GetByCodeZoneResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid BuildingId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ZoneBuildingResponseDto? Building { get; set; }
    public ZoneDepositorCompanyResponseDto? DepositorCompany { get; set; }

}

