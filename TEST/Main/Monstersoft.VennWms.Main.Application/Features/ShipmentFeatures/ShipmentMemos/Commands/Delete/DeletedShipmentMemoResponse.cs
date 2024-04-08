namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Commands.Delete;

public class DeletedShipmentMemoResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
