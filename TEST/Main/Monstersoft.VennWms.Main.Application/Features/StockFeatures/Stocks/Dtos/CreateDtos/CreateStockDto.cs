using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Dtos.CreateDtos;

public class CreateStockDto
{
    public Guid StockContainerId { get; set; }
    public Guid ProductId { get; set; }
    public Guid DepositorId { get; set; }
    public decimal CuQuantity { get; set; }
    public decimal CuQuantityFree { get; set; }
    public Guid LocationId { get; set; }
    public Guid CuItemUnitId { get; set; }
    public Guid ReceiptId { get; set; }
    public Guid ReturnId { get; set; }
    public ICollection<CreateStockAttributeValueSubDto>? StockAttributeValues { get; set; }
    public ICollection<CreateStockMemoSubDto>? StockMemos { get; set; }
    public ICollection<CreateStockReserveReasonSubDto>? StockReserveReasons { get; set; }
    public ICollection<CreateStockUnsuitReasonSubDto>? StockUnsuitReasons { get; set; }
    public ICollection<CreateStockInboundSubDto>? StockInbounds { get; set; }
    public ICollection<CreateStockPackTypeSubDto>? StockPackTypes { get; set; }
}

