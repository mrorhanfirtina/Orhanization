namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Commands.Delete;

public class DeletedStockPackTypeResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}

