namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Commands.Delete;

public class DeletedOrderTypeResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
