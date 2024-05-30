namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Dtos.ResponseDtos;

public class ReturnsReturnAttributeResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public bool IsNecessary { get; set; }
    public ReturnsAttributeInputTypeResponseDto? AttributeInputType { get; set; }
}