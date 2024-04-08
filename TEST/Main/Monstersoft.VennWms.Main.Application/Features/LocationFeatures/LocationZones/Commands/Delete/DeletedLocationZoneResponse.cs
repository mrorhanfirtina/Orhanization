namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Commands.Delete;

public class DeletedLocationZoneResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}

