using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Commands.Create;

public class CreatedReturnAttributeResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public bool IsNecessary { get; set; }
    public DateTime CreatedDate { get; set; }
    public ReturnAttributesDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public ReturnAttributesAttributeInputTypeResponseDto? AttributeInputType { get; set; }
}
