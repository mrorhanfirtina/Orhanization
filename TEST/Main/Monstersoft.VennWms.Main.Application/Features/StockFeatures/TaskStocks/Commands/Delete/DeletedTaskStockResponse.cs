namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Commands.Delete;

public class DeletedTaskStockResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
