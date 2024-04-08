namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Commands.Delete;

public class DeletedBuildingResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}

