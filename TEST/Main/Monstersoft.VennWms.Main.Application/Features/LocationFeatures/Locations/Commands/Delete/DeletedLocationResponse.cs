namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Commands.Delete;

public class DeletedLocationResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
