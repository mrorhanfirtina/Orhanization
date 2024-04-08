namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Queries.GetById;

public class GetByIdProductAttributeResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public bool IsNecessary { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}
