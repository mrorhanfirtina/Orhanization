using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Queries.GetListByDynamic;

public class GetListByDynamicReceiptItmStockAttrValueListItemDto
{
    public Guid Id { get; set; }
    public Guid ReceiptItemId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ReceiptItmStockAttrValuesStockAttributeResponseDto? StockAttribute { get; set; }
    public ReceiptItmStockAttrValuesReceiptItemResponseDto? ReceiptItem { get; set; }
}

