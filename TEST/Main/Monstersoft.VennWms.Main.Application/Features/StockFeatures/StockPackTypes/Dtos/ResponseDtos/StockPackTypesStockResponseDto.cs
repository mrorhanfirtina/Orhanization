namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Dtos.ResponseDtos;

public class StockPackTypesStockResponseDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public decimal CuQuantity { get; set; }
    public decimal CuQuantityFree { get; set; }
    public Guid LocationId { get; set; }
    public Guid CuItemUnitId { get; set; }
    public StockPackTypesProductResponseDto? Product { get; set; }
    public StockPackTypesDepositorResponseDto? Depositor { get; set; }
    public StockPackTypesDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public StockPackTypesLocationResponseDto? Location { get; set; }
    public StockPackTypesItemUnitResponseDto? CuItemUnit { get; set; }
}