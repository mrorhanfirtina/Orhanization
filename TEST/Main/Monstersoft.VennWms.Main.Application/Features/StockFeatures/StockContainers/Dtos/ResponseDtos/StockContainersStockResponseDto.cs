namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Dtos.ResponseDtos;

public class StockContainersStockResponseDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public decimal CuQuantity { get; set; }
    public decimal CuQuantityFree { get; set; }
    public Guid LocationId { get; set; }
    public Guid CuItemUnitId { get; set; }
    public ICollection<StockContainersStockAttributeValueResponseDto>? StockAttributeValues { get; set; }
    public ICollection<StockContainersStockMemoResponseDto>? StockMemos { get; set; }
    public ICollection<StockContainersStockReserveReasonResponseDto>? StockReserveReasons { get; set; }
    public ICollection<StockContainersStockUnsuitReasonResponseDto>? StockUnsuitReasons { get; set; }
    public StockContainersProductResponseDto? Product { get; set; }
    public StockContainersDepositorResponseDto? Depositor { get; set; }
    public StockContainersDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public StockContainersLocationResponseDto? Location { get; set; }
    public StockContainersItemUnitResponseDto? CuItemUnit { get; set; }
}