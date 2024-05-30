using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Queries.GetListByDynamic;

public class GetListByDynamicStockListItemDto
{
    public Guid Id { get; set; }
    public Guid StockContainerId { get; set; }
    public Guid ProductId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public decimal CuQuantity { get; set; }
    public decimal CuQuantityFree { get; set; }
    public Guid LocationId { get; set; }
    public Guid CuItemUnitId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public StocksStockContainerResponseDto? StockContainer { get; set; }
    public ICollection<StocksStockAttributeValueResponseDto>? StockAttributeValues { get; set; }
    public ICollection<StocksStockMemoResponseDto>? StockMemos { get; set; }
    public ICollection<StocksStockReserveReasonResponseDto>? StockReserveReasons { get; set; }
    public ICollection<StocksStockUnsuitReasonResponseDto>? StockUnsuitReasons { get; set; }
    public ICollection<StocksStockInboundResponseDto>? StockInbounds { get; set; }
    public ICollection<StocksStockPackTypeResponseDto>? StockPackTypes { get; set; }
    public StocksProductResponseDto? Product { get; set; }
    public StocksDepositorResponseDto? Depositor { get; set; }
    public StocksDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public StocksLocationResponseDto? Location { get; set; }
    public StocksItemUnitResponseDto? CuItemUnit { get; set; }
}

