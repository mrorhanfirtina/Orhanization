using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Dtos.UpdateDtos;

public class UpdateStockDto
{
    public Guid Id { get; set; }
    public Guid StockContainerId { get; set; }
    public Guid ProductId { get; set; }
    public Guid DepositorId { get; set; }
    public decimal CuQuantity { get; set; }
    public decimal CuQuantityFree { get; set; }
    public Guid LocationId { get; set; }
    public Guid CuItemUnitId { get; set; }
    public Guid ReceiptId { get; set; }
    public Guid ReturnId { get; set; }
    public ICollection<UpdateStockAttributeValueSubDto>? StockAttributeValues { get; set; }
    public ICollection<UpdateStockMemoSubDto>? StockMemos { get; set; }
    public ICollection<UpdateStockReserveReasonSubDto>? StockReserveReasons { get; set; }
    public ICollection<UpdateStockUnsuitReasonSubDto>? StockUnsuitReasons { get; set; }
    public ICollection<UpdateStockInboundSubDto>? StockInbounds { get; set; }
    public ICollection<UpdateStockPackTypeSubDto>? StockPackTypes { get; set; }
}

