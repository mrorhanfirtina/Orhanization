namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Commands.Delete;

public class DeletedStockAttributeResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
