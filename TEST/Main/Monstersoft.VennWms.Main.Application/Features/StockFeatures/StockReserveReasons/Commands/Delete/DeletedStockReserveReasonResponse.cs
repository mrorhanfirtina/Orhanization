namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Commands.Delete;

public class DeletedStockReserveReasonResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}

