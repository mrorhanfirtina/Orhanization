namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Commands.Delete;

public class DeletedStockContainerHierarchyResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}
