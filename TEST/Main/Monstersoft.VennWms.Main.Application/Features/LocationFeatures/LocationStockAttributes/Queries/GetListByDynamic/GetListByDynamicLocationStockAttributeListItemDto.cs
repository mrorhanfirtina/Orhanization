namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Queries.GetListByDynamic;

public class GetListByDynamicLocationStockAttributeListItemDto
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public Guid StockAttributeId { get; set; }
    public bool IsForbid { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}

