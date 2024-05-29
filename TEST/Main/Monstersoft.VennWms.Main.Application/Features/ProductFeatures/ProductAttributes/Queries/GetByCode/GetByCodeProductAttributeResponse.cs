using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Queries.GetByCode;

public class GetByCodeProductAttributeResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public bool IsNecessary { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ProductAttributeAttributeInputTypeResponseDto? AttributeInputType { get; set; }
    public ProductAttributeDepositorCompanyResponseDto? DepositorCompany { get; set; }
}
