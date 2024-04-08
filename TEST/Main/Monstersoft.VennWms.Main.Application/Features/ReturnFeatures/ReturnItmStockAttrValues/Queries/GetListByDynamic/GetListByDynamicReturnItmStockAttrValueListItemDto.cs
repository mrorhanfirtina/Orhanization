namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Queries.GetListByDynamic;

public class GetListByDynamicReturnItmStockAttrValueListItemDto
{
    public Guid Id { get; set; }
    public Guid ReturnItemId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}

