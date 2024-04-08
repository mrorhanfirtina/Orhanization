namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Queries.GetListByDynamic;

public class GetListByDynamicProductAttributeValueListItemDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid ProductAttributeId { get; set; }
    public string Value { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}

