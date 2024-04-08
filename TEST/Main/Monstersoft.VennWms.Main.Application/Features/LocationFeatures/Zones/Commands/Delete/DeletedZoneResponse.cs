namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Commands.Delete;

public class DeletedZoneResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}

