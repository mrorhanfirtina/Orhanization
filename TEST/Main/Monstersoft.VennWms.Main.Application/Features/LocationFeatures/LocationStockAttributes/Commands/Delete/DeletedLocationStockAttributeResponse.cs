namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Commands.Delete;

public class DeletedLocationStockAttributeResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}

