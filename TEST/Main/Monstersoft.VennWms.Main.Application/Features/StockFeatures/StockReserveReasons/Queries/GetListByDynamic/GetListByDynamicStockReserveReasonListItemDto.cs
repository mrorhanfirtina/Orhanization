using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Queries.GetListByDynamic;

public class GetListByDynamicStockReserveReasonListItemDto
{
    public Guid Id { get; set; }
    public Guid StockId { get; set; }
    public Guid ReserveReasonId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public StockReserveReasonsReserveReasonResponseDto? ReserveReason { get; set; }
    public StockReserveReasonsStockResponseDto? Stock { get; set; }
}

