namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Commands.Delete;

public class DeletedStockMemoResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
