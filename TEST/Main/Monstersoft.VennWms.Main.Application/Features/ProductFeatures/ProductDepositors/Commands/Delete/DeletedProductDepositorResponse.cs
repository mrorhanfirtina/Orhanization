namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Commands.Delete;

public class DeletedProductDepositorResponse
{
    public Guid Id { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}


