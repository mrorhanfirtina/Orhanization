namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Dtos.ResponseDtos;

public class ReturnsStockAttributeResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public ReturnsAttributeInputTypeResponseDto? AttributeInputType { get; set; }
}