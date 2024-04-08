namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Queries.GetListByDynamic;

public class GetListByDynamicStockAttributeListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public bool IsNecessary { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}
