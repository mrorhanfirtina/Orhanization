namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Commands.Delete;

public class DeletedStockInboundResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}
