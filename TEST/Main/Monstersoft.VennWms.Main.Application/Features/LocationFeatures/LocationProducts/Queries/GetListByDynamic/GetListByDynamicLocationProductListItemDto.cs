namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Queries.GetListByDynamic;

public class GetListByDynamicLocationProductListItemDto
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public Guid ProductId { get; set; }
    public bool IsForbid { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}
