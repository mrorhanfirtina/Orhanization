namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Commands.AddStock;

public class AddedStockResponse
{
    public Guid StockId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}
