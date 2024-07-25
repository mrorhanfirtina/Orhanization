namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Dtos.ResponseDtos;

public class StockContainerHierarchyStockResponseDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public decimal CuQuantity { get; set; }
    public decimal CuQuantityFree { get; set; }
    public Guid LocationId { get; set; }
    public Guid CuItemUnitId { get; set; }
    public StockContainerHierarchyProductResponseDto? Product { get; set; }
    public StockContainerHierarchyDepositorResponseDto? Depositor { get; set; }
    public StockContainerHierarchyDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public StockContainerHierarchyLocationResponseDto? Location { get; set; }
    public StockContainerHierarchyItemUnitResponseDto? CuItemUnit { get; set; }
}
